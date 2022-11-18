using System;

public class Program
{
    static void Main(string[] args)
    {
        // Task 1 [date = 08-11-2022]
        // Simple calculator demo

        Console.WriteLine("Welcome to Simple Calculator");
        bool iteration = true;
        while (iteration)
        {
            Console.WriteLine("Arthemetic Operations Available");
            Console.WriteLine("Addition - Press 1");
            Console.WriteLine("Subtraction - Press 2");
            Console.WriteLine("Multiplication - Press 3");
            Console.WriteLine("Division - Press 4");

            Console.WriteLine("To exit - press 0");

            Console.WriteLine("please enter the input :");
            int ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 0)
            {
                iteration = false;
            }
            else
            {
                Console.WriteLine("please enter the first number :");
                int fn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter the second number :");
                int sn = Convert.ToInt32(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        Console.WriteLine("The output is :" + (fn + sn));
                        break;
                    case 2:
                        Console.WriteLine("The output is :" + (fn - sn));
                        break;
                    case 3:
                        Console.WriteLine("The output is :" + (fn * sn));
                        break;
                    case 4:
                        Console.WriteLine("The output is :" + (fn / sn));
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }

            }
        }


    }
}

