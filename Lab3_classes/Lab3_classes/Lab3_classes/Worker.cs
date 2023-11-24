using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    [Serializable]
    public abstract class Worker
    {
        public int Id;
        public bool isWorking;
        public float salary;
        // Дней проработано
        public float loyalityRate { get; set; }
        public abstract void StartDay();
        public abstract void EndDay();
        public abstract void PrintSalary();
        public abstract float CalculateRate();
        public abstract void Fire();
        public abstract void LoyaltyFine(float fine);
        public Worker(float salary_)
        {
            salary = salary_;
            loyalityRate = 0;
        }
        public Worker(float salary_, float loyality)
        {
            salary = salary_;
            loyalityRate = loyality;
        }
        public Worker()
        {
            salary = 50000;
            loyalityRate = 0;
        }
        

    }
}
