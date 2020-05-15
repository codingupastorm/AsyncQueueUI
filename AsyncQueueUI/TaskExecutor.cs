using AsyncQueueUI.Interfaces;

namespace AsyncQueueUI
{
    public class TaskExecutor : ITaskExecutor
    {
        private readonly ITaskQueue taskQueue;

        public TaskExecutor(ITaskQueue taskQueue)
        {
            this.taskQueue = taskQueue;
        }

        /// <summary>
        /// Will start a loop on a new thread that is constantly waiting / getting items from taskQueue and executing them.
        /// </summary>
        public void Start()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Probably have a reference to the loop / thread that we may need to clean up here.
        /// </summary>
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
