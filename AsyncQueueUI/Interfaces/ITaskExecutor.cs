using System;

namespace AsyncQueueUI.Interfaces
{
    public interface ITaskExecutor : IDisposable
    {
        /// <summary>
        /// Starts a new loop that will be constantly executing tasks.
        /// </summary>
        void Start();
    }
}
