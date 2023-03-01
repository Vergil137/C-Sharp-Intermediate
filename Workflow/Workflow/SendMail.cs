namespace Workflow
{
    public class SendMail : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Sending Mail");
        }
    }
}
