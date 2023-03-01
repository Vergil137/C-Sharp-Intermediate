using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    public class Post
    {
        public string Title { get; }
        public string Description { get; }
        public DateTime Created { get; } = DateTime.Now;

        public int UpVotes { get; private set; }
        public int DownVotes { get; private set; }

        public Post(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                throw new ArgumentNullException("title or description");

            Title = title.Trim();
            Description = description.Trim();
        }

        public void UpVote()
        {
            UpVotes += 1;
        }
        
        public void DownVote()
        {
            DownVotes += 1;
        }

        public int GetVotes()
        {
            return UpVotes + DownVotes;
        }
    }
}
