using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();
            watch.Stop();
            Console.WriteLine(watch.Duration);
            watch.Start();
            Thread.Sleep(2000);
            watch.Stop();
            Console.WriteLine(watch.Duration);
        }
    }
}
