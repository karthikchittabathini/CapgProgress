using System;
using LitwareLibrary;

namespace LitwareApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ------------------ EMPLOYEE MANAGEMENT CODE STARTS --------------------------------
            // Task 3 [date = 10-11-2022]

            Console.WriteLine("Welcome to Litware Application!");
            Employee e1 = new Employee(1, "karthik", 30000, "employee", 0);
            e1.CalculateSalary();
            e1.EmpDetails();
            Console.ReadLine();


        }
    }
}
