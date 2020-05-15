using AsyncQueueUI.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace AsyncQueueUI
{
    /// <summary>
    /// An example of a task queue that holds the items in memory. Could be replaced with some persistent database in another implementation.
    /// </summary>
    public class InMemoryTaskQueue : ITaskQueue
    {
        private readonly ConcurrentQueue<TaskWrapper> queue;

        /// <summary>
        /// In this example we will put <see cref="UIController.Render"/> here.
        /// This will be called when changes are made the task queue. e.g. On add, remove, task complete, etc.
        /// </summary>
        private Action callback;

        public InMemoryTaskQueue()
        {
            this.queue = new ConcurrentQueue<TaskWrapper>();
        }

        public void Enqueue(TaskWrapper task)
        {
            throw new System.NotImplementedException();
        }

        public TaskWrapper Dequeue()
        {
            throw new System.NotImplementedException();
        }

        public void InsertAtIndex(TaskWrapper task, int index)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TaskWrapper> GetTasks()
        {
            throw new System.NotImplementedException();
        }

        public void OnUpdate(Action callback)
        {
            throw new NotImplementedException();
        }
    }
}
