using System;
// 1. we get output 4 lines as FN LN
// 2. if we want to print -Fulltime , -Parttime with name then ?

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "-Part Time");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "-Full Time");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "-Temporary");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
