using System;

namespace DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
        public override void Open()
        {
            Console.WriteLine("Connection to SQL Database opened");
        }

        public override void Close()
        {
            Console.WriteLine("Connection to SQL Database closed");

        }
    }
}
