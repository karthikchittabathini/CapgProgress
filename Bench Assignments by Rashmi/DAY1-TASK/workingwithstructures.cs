// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.VisualBasic;
using practicesessions;
using System;

public class DemoMain
{
    //string name = "Karthik Chittabathini";

    
    // ---------- WORKING WITH STRUCTURES ---------------------
    // Task 1 [date = 08-11-2022]
    struct Book
    {
        public int bookid { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        
        enum bookType 
        {
            Magazine, 
            Novel, 
            ReferenceBook, 
            Miscellaneous
        }


        public void AssignValues(int b, string t, int p)
        {
            this.bookid = b;
            this.title = t;
            this.price = p;
        }

        public void DisplayValues()
        {
            Console.WriteLine(this.bookid);
            Console.WriteLine(this.title);
            Console.WriteLine(this.price);
            Console.WriteLine(bookType.ReferenceBook);
        }

    }
   
    
    public static void Main()
    {
     
        // ----------- W0RKING WITH STRUCTURES(BOOK) --------------------
        // Task 1 [date = 08-11-2022]
        //CODE STARTS

        Book b = new Book();
        b.AssignValues(1, "ThinkBig", 170);
        b.DisplayValues();

    }
}
