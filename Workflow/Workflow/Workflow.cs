using System;
using System.Collections.Generic;

namespace Workflow
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public Workflow(List<IActivity> activities)
        {
            if (activities.Count < 1)
                throw new ArgumentNullException(nameof(activities));

            _activities = activities;
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        IEnumerable<IActivity> IWorkflow.GetActivities()
        {
            return _activities;
        }
    }
}
