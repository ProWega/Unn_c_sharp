using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public class StudentWithAdvisor : Student
    {
        Teacher teacher;

        public StudentWithAdvisor(string _name, int age_, Teacher teacher) : base(_name, age_)
        {
            this.teacher = teacher;
            teacher.AddStudent(this);
        }
        public override object Clone()
        {
            return new StudentWithAdvisor(name, age, teacher);
        }
        public override string ToString()
        {
            return $"Student {name}, {age} years old with teacher {teacher.name}";
        }
    }
}
