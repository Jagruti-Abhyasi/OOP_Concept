using System;
// Inhetitance allow us code reusability
// code reusable can reduce time and error
namespace Inheritance
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    //Derived class : base class , now all properties and methods available to derived class
    public class FullTimeEmployee :Employee
    {
        public float YearlySalary;
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Anisha";
            FTE.LastName = "Patel";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Part";
            PTE.LastName = "Das";
            PTE.HourlyRate = 100;
            PTE.PrintFullName();

        }
    }
}
