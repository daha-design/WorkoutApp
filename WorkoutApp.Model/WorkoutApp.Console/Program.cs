using System;
using WorkoutApp.Model;

namespace WorkoutApp.ConsoleView
{
    class Program
    {
        static void Main()
        {
            Logic logic = new Logic();

            // Создание
            logic.CreateWorkout("Бег на дорожке", "Кардио", 1, 1, 0, DateTime.Now.AddDays(-2));
            logic.CreateWorkout("Жим лёжа", "Силовая", 4, 10, 60, DateTime.Now.AddDays(-1));
            logic.CreateWorkout("Приседания", "Силовая", 5, 8, 80, DateTime.Now);
            logic.CreateWorkout("Растяжка шпагата", "Растяжка", 3, 1, 0, DateTime.Now);

            // Чтение
            Console.WriteLine("=== Все тренировки ===");
            foreach (var w in logic.GetWorkouts())   // ← GetWorkouts, не GetAllWorkouts
                Console.WriteLine(w);

            // Изменение
            logic.UpdateWorkout(2, "Жим лёжа (наклонная)", "Силовая", 4, 12, 55, DateTime.Now.AddDays(-1));

            // Бизнес-функция 1
            Console.WriteLine($"\nОбщий поднятый вес: {logic.GetTotalLiftedWeights()} кг");   // ← с "s" на конце

            // Бизнес-функция 2
            Console.WriteLine("\nСтатистика по типам:");
            foreach (var pair in logic.GetWorkoutsCountBytype())   // ← bytype, не byType
                Console.WriteLine($"{pair.Key}: {pair.Value}");

            // Удаление
            logic.DeleteWorkout(1);

            Console.WriteLine("\nПосле удаления:");
            foreach (var w in logic.GetWorkouts())
                Console.WriteLine(w);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}