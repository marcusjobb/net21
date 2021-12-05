namespace OOA_Inlamning1.Helpers
{
    using Dapper;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    internal static class SqlHelpers
    {
        internal static int ExecuteScalar(string sql, string connectionString = "PeopleDB")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnStr(connectionString)))
            {
                return connection.ExecuteScalar<int>(sql);
            }
        }

        internal static void Execute(string sql, string connectionString = "PeopleDB")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnStr(connectionString)))
            {
                connection.Execute(sql);
            }
        }

        internal static List<Person> QueryPerson(string sql, string connectionString = "PeopleDB")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnStr(connectionString)))
            {
                return connection.Query<Person>(sql).ToList();
            }
        }

        internal static List<(string, int)> QueryTupleStringInt(string sql, string connectionString = "PeopleDB")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnStr(connectionString)))
            {
                return connection.Query<(string, int)>(sql).ToList();
            }
        }

        internal static List<(int, int, int)> QueryTupleIntIntInt(string sql, string connectionString = "PeopleDB")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnStr(connectionString)))
            {
                return connection.Query<(int, int, int)>(sql).ToList();
            }
        }

        internal static List<Person> UserQuery(string column, string tableName, string searchFor)
        {
            string sql = $"SELECT * FROM {tableName} WHERE {column} LIKE @Search ORDER BY {column}";
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnStr("PeopleDB")))
            {
                return connection.Query<Person>(sql, new { Search = searchFor + "%" }).ToList();
            }
        }
    }
}
