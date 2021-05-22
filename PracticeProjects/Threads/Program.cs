using System;
using System.Linq;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            var taskGenerator = new TasksGenerator();
            var lockObj = new object();

            var sampleTasks = taskGenerator.GetSampleTasks().ToList();
            var threads = worker.CreateThreads(sampleTasks);

            threads.ForEach(thread => thread.Start());
            threads.ForEach(thread => thread.Join());                 

            Console.WriteLine("End Of Main Thread!");
        }
    }
}
