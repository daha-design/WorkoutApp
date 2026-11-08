using System.Configuration;
using Ninject.Modules;
using WorkoutApp.Domain;
namespace WorkoutApp.DataAccessLayer
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            // 1. Убираем строку с SqlProviderServices.Instance (она больше не нужна)

            // 2. Регистрируем контекст БД, чтобы Ninject мог его создать
            Bind<WorkoutAppDbContext>().ToSelf();

            // 3. Привязываем интерфейс к реализации EF (по умолчанию)
            Bind<IRepository<Workout>>()
                .To<EntityRepository<Workout>>()
                .InSingletonScope();

            // 4. Настраиваем Dapper на случай переключения
            // Читаем строку подключения из App.config
            string connectionString = ConfigurationManager.ConnectionStrings["WorkoutDb"].ConnectionString;

            Bind<IRepository<Workout>>()
    .To<DapperRepository<Workout>>()
    .WhenInjectedInto<Logic>() // <--- СНАЧАЛА ЭТО
    .WithConstructorArgument("connectionString", connectionString); // <--- ПОТОМ ЭТО
            // ВАЖНО: Чтобы переключиться на Dapper, просто закомментируй блок с EF (пункт 3)
            // и оставь только этот блок с Dapper.
        }
    }
}