using AsyncQueueUI.Interfaces;
using System;
using System.Threading.Tasks;

namespace AsyncQueueUI
{
    public class UIController
    {
        private readonly ITaskQueue taskQueue;

        public UIController(ITaskQueue taskQueue)
        {
            this.taskQueue = taskQueue;
            this.taskQueue.SetCallback(this.Render);
        }

        public void OnTaskCanceledButtonHandler()
        {
            throw new NotImplementedException();
        }

        public void OnTaskMovedButtonHandler()
        {
            throw new NotImplementedException();
        }

        
        public void Render()
        {
            Task.Run(() =>
            {
                throw new NotImplementedException();
            });
        }
    }
}
