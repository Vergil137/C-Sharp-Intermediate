using System;

namespace DbConnection
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _command;

        public DbCommand(DbConnection connection, string command)
        {
            if (connection == null)
                throw new ArgumentNullException();

            if (string.IsNullOrWhiteSpace(command))
                throw new ArgumentNullException(command);

            _connection = connection;
            _command = command;
        }

        public void Execute()
        {
            _connection.Open();
            Console.WriteLine(_command);
            _connection.Close();
        }
    }
}
