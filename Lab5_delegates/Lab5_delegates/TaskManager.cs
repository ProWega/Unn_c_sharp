using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_delegates
{
    public class TaskManager
    {
        public List<Task> tasks = new List<Task>();

        public TaskManager()
        {

        }
        public void CompleteTask(Task task)
        {
            if (!tasks.Contains(task))
            {
                tasks.Add(task);
            }
            task.Complete();    
        }
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
            }
        }
    }
}
