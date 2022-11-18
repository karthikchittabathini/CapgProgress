using System;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello");

        // reading the sub folder names and count in a main folder
        try
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\MainFolder\");

            DirectoryInfo[] dir1 = di.GetDirectories();
            Console.WriteLine("The number of sub directories/ sub folders containing are {0}.", dir1.Length);

            for (int i = 0; i < dir1.Length; i++)
            {
                Console.WriteLine(dir1[i].Name);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }


        // read from a text file 
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Reading from a text file");

        // read all text as a single string
        string text = System.IO.File.ReadAllText(@"D:\MainFolder\subfolder1\demo.txt");

        //reads and returns all lines and sends them into the string array
        string[] txt = System.IO.File.ReadAllLines(@"D:\MainFolder\subfolder1\demo.txt");
        Console.WriteLine(text);

        // iterating through the array 
        foreach(string line in txt)
        {
            Console.WriteLine(line);
        }


    }

}
