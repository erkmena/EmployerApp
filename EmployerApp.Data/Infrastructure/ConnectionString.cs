namespace EmployerApp.Data.Infrastructure
{
    public static class ConnectionString
    {
        /// The client channel connection string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string EmployerAppConnectionString()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["EmployerAppConnectionString"].ToString();
            return connectionString;
        }
    }
}
