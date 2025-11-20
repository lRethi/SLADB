using Microsoft.Data.SqlClient;

namespace BancoDadosMTG
{
    public static class Database
    {
        private static string connectionString =
         @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Andery;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}