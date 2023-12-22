using System;
using Lab4_abstract;
TestToStringMethod();
TestEquals();
TestHashCode();

Teacher teacher = new Teacher("Андрей Васильевич", 43);
StudentWithAdvisor student = new StudentWithAdvisor("Илья", 20, teacher);
Console.WriteLine(teacher.ToString());
Console.WriteLine();
Console.WriteLine(student.GetType());
Console.WriteLine(student.GetType().BaseType);
Console.WriteLine(student.GetType().BaseType.BaseType);
Console.WriteLine(student.GetType().BaseType.BaseType.BaseType);
Console.WriteLine(student.GetType().BaseType.BaseType.BaseType.BaseType);





void TestToStringMethod()
{
    Console.WriteLine("ВЫВОД МЕТОДА ToString():");
    Console.WriteLine("---------------------------------------------------");
    Person testPerson = new Person("Test person");
    Student testStudent = new Student("Иван", 16);
    Teacher testTeacher = new Teacher("Test teacher", 45);
    Teacher teacher_without_students = new Teacher("Марфа Петровна", 63);

    testTeacher.AddStudent(testStudent);

    Console.WriteLine(testPerson.ToString());
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine(testStudent.ToString());
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine(testTeacher.ToString());
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine(teacher_without_students.ToString());
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine();
}
void TestEquals()
{
    Console.WriteLine("ТЕСТ МЕТОДА EQUALS():");
    Console.WriteLine("---------------------------------------------------");

    Person testPerson = new Person("Test person");
    Person testPerson2 = new Person("Test person");
    Student testStudent = new Student("Иван", 16);
    Teacher testTeacher = new Teacher("Test teacher", 45);
    Student testStudent2 = new Student("Иван", 16);
    Teacher testTeacher2 = new Teacher("Test teacher", 45);

    Console.WriteLine("ВЫВОД МЕТОДА Equals():");
    Console.WriteLine("Person 1:");
    Console.WriteLine(testPerson.ToString());
    Console.WriteLine("Person 2:");
    Console.WriteLine(testPerson2.ToString());
    Console.WriteLine("~~~~~~~~~~ is equals ~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine(testPerson.Equals(testPerson2));
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine();

}

void TestHashCode()
{
    Console.WriteLine("ВЫВОД МЕТОДА GetHashCode():");
    Console.WriteLine("---------------------------------------------------");

    Student testStudent = new Student("Иван", 16);
    Student testStudent2 = new Student("Иван", 16);

    Console.WriteLine("CТУДЕНТЫ:");
    Console.WriteLine("First student");
    Console.WriteLine(testStudent.ToString());
    Console.WriteLine("Second student");
    Console.WriteLine(testStudent2.ToString());
    Console.WriteLine("~~~~~~~~~~ print hash codes ~~~~~~~~~~~~~~~~");
    Console.WriteLine(testStudent.GetHashCode());
    Console.WriteLine(testStudent2.GetHashCode());
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine();

}