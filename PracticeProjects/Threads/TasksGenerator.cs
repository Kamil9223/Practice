using System;
using System.Collections.Generic;

namespace Threads
{
    internal class TasksGenerator
    {
        public IEnumerable<Action> GetSampleTasks()
        {
            yield return () => Console.WriteLine("1 task");
            yield return () => Console.WriteLine("2 task");
            yield return () => Console.WriteLine("3 task");
            yield return () => Console.WriteLine("4 task");
            yield return () => Console.WriteLine("5 task");
            yield return () => Console.WriteLine("6 task");
            yield return () => Console.WriteLine("7 task");
            yield return () => Console.WriteLine("8 task");
            yield return () => Console.WriteLine("9 task");
            yield return () => Console.WriteLine("10 task");
            yield return () => Console.WriteLine("11 task");
            yield return () => Console.WriteLine("12 task");
        }
    }
}
