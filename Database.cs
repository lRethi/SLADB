using System.Data.SqlClient;


namespace BancoDadosMTG
{
    public static class Database
    {
        private static string connectionString =
         @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Andery;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}