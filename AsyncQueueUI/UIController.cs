using AsyncQueueUI.Interfaces;
using System;
using System.Threading.Tasks;

namespace AsyncQueueUI
{
    /// <summary>
    /// Manages the UI. Might be a Window in WPF
    /// </summary>
    public class UIController
    {
        private readonly ITaskQueue taskQueue;

        public UIController(ITaskQueue taskQueue)
        {
            this.taskQueue = taskQueue;

            // Get our UI re-rendering when our queue progresses / changes.
            this.taskQueue.OnUpdate(this.Render);
        }

        /// <summary>
        /// Some examples of actions / buttons that will come through and cause actions on the queue. e.g. <see cref="ITaskQueue.Remove(int)"/>.
        /// </summary>
        private void OnTaskCanceledButtonHandler(object sender, EventArgs @event)
        {
            throw new NotImplementedException();
        }

        private void OnTaskMovedButtonHandler(object sender, EventArgs @event)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Outputs views based on data from the queue.
        /// Gets called when the queue updates.
        /// </summary>
        private void Render()
        {
            Task.Run(() =>
            {
                throw new NotImplementedException();
            });
        }
    }
}
