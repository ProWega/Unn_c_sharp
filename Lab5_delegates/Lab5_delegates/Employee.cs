using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_delegates
{
    internal class Employee : IEmployee
    {
        float work_time;
        float relax_time;
        public string Name;

        public delegate void WorkPerformedEventHandler(int hours);
        public delegate void BreakTakenEventHandler(int minutes);

        public event WorkPerformedEventHandler WorkPerformed;
        public event BreakTakenEventHandler BreakTaken;

        public Employee(string name)
        {
            Name = name;
        }
        public void TakeBreak(int minutes)
        {
            relax_time += minutes;
            BreakTaken.Invoke(minutes);
        }

        public void Work(int hours)
        {
            work_time += hours;
            WorkPerformed.Invoke(hours);
        }
    }
}
