using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Threads
{
    internal class Worker
    {
        private const int TasksPerThread = 5;

        public List<ThreadWrapper> CreateThreads(IEnumerable<Action> tasks)
        {
            var numberOfThreads = CalculateNumberOfThreads(tasks.Count());

            var threads = new List<ThreadWrapper>(numberOfThreads);
            for (int i = 0; i< numberOfThreads; i++)
            {
                var selectedTasks = tasks.Skip(i * TasksPerThread)
                                         .Take(TasksPerThread)
                                         .ToList();

                threads.Add(new ThreadWrapper(
                    new Thread(() =>
                {
                    selectedTasks.ForEach(x => x.Invoke());
                }), i+1));
            }

            return threads;
        }

        private int CalculateNumberOfThreads(int numberOfTasks)
        {
            return numberOfTasks / TasksPerThread + (numberOfTasks % TasksPerThread > 0 ? 1 : 0);
        }
    }
}
