using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Please enter the Number");
      string num = Console.ReadLine();
      
      int output;
      
      bool isChangable = Int32.TryParse(num, out output);
      
      if(isChangable){
          Console.WriteLine(output);
      }
      else{
          Console.WriteLine("Cannot be Parsed");
      }
      
    }
}
