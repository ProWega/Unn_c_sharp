using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_delegates
{
    public class TaskCompletedNotification
    {
        public void CompleteMessage(Task task)
        {
            Console.WriteLine($"Задача {task.Name} выполнена, описание: {task.description}");
        }
    }
}
