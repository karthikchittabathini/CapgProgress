using System;
using LitwareLibrary;

namespace LitwareApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ------------------ EMPLOYEE MANAGEMENT CODE STARTS --------------------------------
            // Task 2 [date = 09-11-2022]

            Console.WriteLine("Welcome to Litware Application!");
            Employee e1 = new Employee(1, "karthik", 30000);
            e1.CalculateSalary();
            Console.ReadLine();


        }
    }
}
