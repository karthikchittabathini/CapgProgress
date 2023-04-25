using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter the first string");
      string first = Console.ReadLine();
      
      Console.WriteLine("Enter the second string");
      string second = Console.ReadLine();
      
      
      string reverse = string.Empty;
      foreach (char c in first)
      {
          reverse = c + reverse;
      }
      
      if(reverse == second)
      {
          Console.WriteLine("The two strings are reverse of each other");
      }
      else
      {
          Console.WriteLine("No, They are not reverse of each other");
      }
  }
}