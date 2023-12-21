namespace DbClasses
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("connectionString is required.");
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }
}
