using System;

public class Program
{
    static void Main(string[] args)
    {
       
       //---------- Circle circumference and area ------------
       // Task 1 [date = 08-11-2022]
       //CODE STARTS

       circle c = new circle();
       (double circumference, double area) = c.CircumferenceAndArea(2);
       Console.WriteLine("The circumference of the circle was :" + circumference);
       Console.WriteLine("The area of the circle was :" + area);

    }
}