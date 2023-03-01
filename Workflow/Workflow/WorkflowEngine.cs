using System;

namespace Workflow
{
    public class WorkflowEngine
    {
        private readonly IWorkflow _workflow;

        public WorkflowEngine(IWorkflow workflow)
        {
            if (workflow == null)
                throw new ArgumentNullException(nameof(workflow));

            _workflow = workflow;
        }

        public void Run()
        {
            foreach (IActivity activity in _workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
