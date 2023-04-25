using System;
namespace Demo {
   class Program {
      static void Main(string[] args) {
         object str = "hello";
         char[] values = {'h','e','l','l','o'};
         object str2 = new string(values);
         Console.WriteLine("Equality operator: {0}", str == str2);
         Console.WriteLine("equals() method: {0}", str.Equals(str2));
         Console.ReadKey();
      }
   }
}