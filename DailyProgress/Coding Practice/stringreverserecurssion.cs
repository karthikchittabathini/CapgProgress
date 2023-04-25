 using System;

 namespace Reverse {
   class Program {
     public static void Main() {
       string str = "this is a test";
       Reverse rsObj = new Reverse();
       Console.WriteLine("Original string: " + str);
       Console.Write("Reversed string: ");
       rsObj.displayReverse(str);
       Console.ReadKey();
     }
   }
   class Reverse {
     public void displayReverse(string str) {
       if (str.Length > 0)
         displayReverse(str.Substring(1, str.Length - 1));
       else
         return;
       Console.Write(str[0]);
     }
   }
 }