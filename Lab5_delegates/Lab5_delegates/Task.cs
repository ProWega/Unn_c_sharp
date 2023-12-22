using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_delegates
{
    public class Task
    {
        private string _name;
        public string Name { get; set; }
        public string description;
        public bool isDone = false;
        public delegate void CompleteDelegate(Task task);
        public event CompleteDelegate OnComplete;

        public Task(string name, string description)
        {
            _name = name;
            this.description = description;
        }
        public void Complete()
        {
            isDone = true;
            OnComplete.Invoke(this);
        }
    }
}
