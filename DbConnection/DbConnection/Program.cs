namespace DbConnection
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("sql");

            sql.Open();
            sql.Close();

            var oracle = new OracleConnection("oracle");

            oracle.Open();
            oracle.Close();

            System.Console.WriteLine();
            System.Console.WriteLine();

            var commandString = "Running Command";
            var command = new DbCommand(sql, commandString);

            command.Execute();

            command = new DbCommand(oracle, commandString);

            command.Execute();
        }
    }
}
