using System;

namespace DbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }
        public override void Open()
        {
            Console.WriteLine("Connection to Oracle Database opened");
        }

        public override void Close()
        {
            Console.WriteLine("Connection to Oracle Database closed");
        }

    }
}
