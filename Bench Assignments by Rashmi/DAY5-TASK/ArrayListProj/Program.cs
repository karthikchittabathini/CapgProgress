using System.Collections;

class Program
{
    public static void Main(String[] args)
    {

        // Array list
        Console.WriteLine("--- Array List ---");

        var emp1 = new ArrayList();

        emp1.Add("Karthik Chittabathini");
        emp1.Add(14218);
        emp1.Add("Capgemini");
        emp1.Add("Analyst");


        // display or iterate over the array list 

        foreach(var item in emp1)
        {
            Console.WriteLine(item);
        }
    }
}