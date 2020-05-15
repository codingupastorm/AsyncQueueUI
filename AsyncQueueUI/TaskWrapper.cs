using System.Threading.Tasks;

namespace AsyncQueueUI
{
    public class TaskWrapper
    {
        /// <summary>
        ///  Unique identifier.
        /// </summary>
        public int Id { get; }

        /// <summary>
        ///  An example of metadata you might want about the task.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///  The task to run.
        /// </summary>
        public Task Task { get; }

        // Note we could also add cmd params etc, to run jobs that aren't just C# code
    }
}

