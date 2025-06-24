using System.Data.SqlClient;

namespace BankManagementSystem
{
    public static class DatabaseHelper
    {
        // This connection string has been corrected by removing the unsupported 'Trust Server Certificate' keyword.
        // This is the correct format for your setup.
        private static readonly string connectionString = "Data Source=NAZMUL\\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;";

        /// <summary>
        /// Creates and returns an open SQL connection.
        /// </summary>
        /// <returns>An open SqlConnection object.</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // The connection is opened here.
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                // This block catches any errors that occur while trying to connect to the database.
                // For a real application, you might log this error to a file.
                // For now, re-throwing it provides detailed debug information.
                throw new System.Exception("Could not connect to the database. Please check your connection string and ensure the SQL Server is running.", ex);
            }
        }
    }
}
