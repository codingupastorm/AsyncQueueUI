using System;
using System.Collections.Generic;

namespace AsyncQueueUI.Interfaces
{
    public interface ITaskQueue
    {
        /// <summary>
        /// Adds a task to the back of the queue.
        /// </summary>
        void Enqueue(TaskWrapper task);

        /// <summary>
        /// Returns the item at the front of the queue and removes it from the queue.
        /// </summary>
        TaskWrapper Dequeue();

        /// <summary>
        /// Inserts a task at the given index. Together with <see cref="Remove"/> can be used to move tasks.
        /// </summary>
        void InsertAtIndex(TaskWrapper task, int index);

        /// <summary>
        /// Removes the task with the given ID from the queue.
        /// Returns whether it was found or not.
        /// </summary>
        void Remove(int id);

        /// <summary>
        /// Get all the known tasks. Useful for displaying current status.
        /// </summary>
        IEnumerable<TaskWrapper> GetTasks();

        /// <summary>
        /// Set a method to be called when changes happen in the queue.
        /// </summary>
        void SetCallback(Action callback);

    }
}