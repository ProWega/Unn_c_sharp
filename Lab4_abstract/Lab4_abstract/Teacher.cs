using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public class Teacher : Person
    {
        static Random random = new Random();
        List<Student> students = new List<Student>();
        public static List<Teacher> All = new List<Teacher>();
        public Teacher(string _name, int age_) :base(_name, age_)
        {
            All.Add(this);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public override string ToString()
        {
            string text = $"Teacher {base.name}, age: {age}\nStudents:\n";
            if (students.Count() > 0)
            {
                foreach (Student student in students)
                {
                    text += student.ToString();
                    text += "\n";
                }
            }
            else
            {
                text += "Teacher without students :(";
            }
            return text;
        }
        virtual public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public override bool Equals(object? obj)
        {
            if (obj.ToString() == this.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override object Clone()
        {
            Teacher new_teacher = new Teacher(name, age);
            new_teacher.students = students;
            return new_teacher;
        }
        public static Teacher RandomTeacher()
        {
            return All[random.Next(All.Count() - 1)];
        }
    }
}
