using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var title = "Post Title";
            var description = "Some Descriptions";

            var post = new Post(title, description);

            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();
            post.DownVote();

            Console.WriteLine(post.UpVotes);
            Console.WriteLine(post.DownVotes);
            Console.WriteLine(post.GetVotes());
        }
    }
}
