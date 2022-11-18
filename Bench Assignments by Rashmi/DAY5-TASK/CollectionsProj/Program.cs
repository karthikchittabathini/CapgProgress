using System;
using System.Net.Http.Headers;

class Program
{
    public static void Main(String[] args)
    {
        int[] marks = new int[] {78, 76, 80};
        string[] names = new string[] {"zkarthik", "neeraj", "purush"};


        // copy int array
        int[] markscopy = new int[3];
        Array.Copy(marks,markscopy,marks.Length);
        Console.WriteLine("--- copied int Array --");
        displayArray();


        void displayArray()
        {
            for (int i = 0; i < markscopy.Length; i++)
            {
                Console.WriteLine(markscopy[i]);
            }
        }


        // copy string array
        //string[] namescopy = new string[3];
        //Array.Copy(names,namescopy,names.Length);

        //for (int i = 0; i < namescopy.Length; i++)
        //{
        //    Console.WriteLine(namescopy[i]);
        //}


        // sort the int array
        Console.WriteLine("--- array after sorting ---");
        Array.Sort(markscopy);
        displayArray();


        //Array.Sort(namescopy);
        //for (int i = 0; i < namescopy.Length; i++)
        //{
        //    Console.WriteLine(namescopy[i]);
        //}


        // reverse a array
        Console.WriteLine("--- Reverse a array ---");
        Array.Reverse(markscopy);
        displayArray();

        //clear a array
        Console.WriteLine("--- clear a array ---");
        Array.Clear(markscopy);
        displayArray();
    }

    
}

