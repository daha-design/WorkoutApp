using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using Dapper;
using WorkoutApp.Domain;

namespace WorkoutApp.DataAccessLayer
{
    public class DapperRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        private readonly string _connectionString;

        public DapperRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private static string TableName => typeof(T).Name + "s";

        public void Add(T item)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.Name != "Id").ToList();
            var columns = string.Join(", ", props.Select(p => p.Name));
            var values = string.Join(", ", props.Select(p => "@" + p.Name));
            string sql = $"INSERT INTO {TableName} ({columns}) VALUES ({values})";

            using (var conn = new SqlConnection(_connectionString))
                conn.Execute(sql, item);
        }

        public void Update(T item)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.Name != "Id").ToList();
            var setClause = string.Join(", ", props.Select(p => $"{p.Name} = @{p.Name}"));
            string sql = $"UPDATE {TableName} SET {setClause} WHERE Id = @Id";

            using (var conn = new SqlConnection(_connectionString))
                conn.Execute(sql, item);
        }

        public void Delete(int id)
        {
            string sql = $"DELETE FROM {TableName} WHERE Id = @Id";
            using (var conn = new SqlConnection(_connectionString))
                conn.Execute(sql, new { Id = id });
        }

        public IEnumerable<T> ReadAll()
        {
            string sql = $"SELECT * FROM {TableName}";
            using (var conn = new SqlConnection(_connectionString))
                return conn.Query<T>(sql).ToList();
        }

        public T ReadById(int id)
        {
            string sql = $"SELECT * FROM {TableName} WHERE Id = @Id";
            using (var conn = new SqlConnection(_connectionString))
                return conn.QueryFirstOrDefault<T>(sql, new { Id = id });
        }
    }
}
