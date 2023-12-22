using Lab5_delegates;

Employee Ivan = new Employee("Ivan");
Employee Igor = new Employee("Igor");
Employee Ilya = new Employee("Ilya");
Employee Ismail = new Employee("Ismail");

List<Employee> Employees = new List<Employee> {Ivan, Igor, Ilya, Ismail};

foreach(Employee employee in Employees)
{
    employee.BreakTaken += (x) => Console.WriteLine($"{employee.Name} отдыхает {x} минут");
    employee.WorkPerformed += (x) => Console.WriteLine($"{employee.Name} работает {x} часов");
}

Ivan.TakeBreak(20);
Igor.TakeBreak(20);
Ilya.Work(int.MaxValue);
Ismail.TakeBreak(5);
