using System.Collections.Generic;

namespace Workflow
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<IActivity>();
            activities.Add(new UploadVideo());
            activities.Add(new Encode());
            activities.Add(new SendMail());
            activities.Add(new ChangeDbRecord());

            var workflowEnging = new WorkflowEngine(new Workflow(activities));

            workflowEnging.Run();
        }
    }
}
