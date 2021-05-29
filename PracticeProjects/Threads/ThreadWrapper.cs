using System.Threading;

namespace Threads
{
    internal class ThreadWrapper
    {
        private readonly Thread _thread;
        private readonly int _priority;

        public ThreadWrapper(Thread thread, int priority)
        {
            _thread = thread;
            _priority = priority;
        }

        public Thread Thread { get => _thread; }

        /// <summary>
        /// Priority of thread invocation. Lowest priority win.
        /// </summary>
        public int Priority { get => _priority; }
    }
}
