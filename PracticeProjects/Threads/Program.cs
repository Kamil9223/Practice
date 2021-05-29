using System;
using System.Linq;

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
            var threadsWrappers = worker.CreateThreads(sampleTasks);

            //uruchamianie wątków jeden po drugim
            //foreach(var threadWrapper in threadsWrappers)
            //{
            //    threadWrapper.Thread.Start();
            //    threadWrapper.Thread.Join();
            //}

            threadsWrappers.ForEach(tw => tw.Thread.Start());
            threadsWrappers.ForEach(tw => tw.Thread.Join());

            Console.WriteLine("End Of Main Thread!");
        }
    }
}
