namespace Workflow
{
    public class ChangeDbRecord : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Record changing");
        }
    }
}
