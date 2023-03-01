using System;

namespace DbConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(connectionString);

            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
