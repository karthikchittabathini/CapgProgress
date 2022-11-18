using System;

public class Program
{
    static void Main(string[] args)
    {
        // Task 1 [date = 08-11-2022]
        // CODE STARTS

        double[] AverageMarks = new double[5];
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Student " + i + " please enter the marks");
            Console.WriteLine("Enter marks obtained in maths");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in physics");
            int physics = Convert.ToInt32(Console.ReadLine());

            double avg = (maths + physics) / 2;

            AverageMarks[i - 1] = avg;
        }

        int stdno = 1;
        double highest = AverageMarks[0];
        for (int i = 0; i <= 4; i++)
        {

            if (AverageMarks[i] > highest)
            {
                highest = AverageMarks[i];
                stdno = i + 1;
            }
        }

        Console.WriteLine("The highest marks are obtained by student " + stdno + " = " + highest);

    }
}

