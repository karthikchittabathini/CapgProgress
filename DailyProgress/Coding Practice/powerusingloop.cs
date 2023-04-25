using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Please enter the Number");
      int num = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Please enter the power value");
      int pow = Convert.ToInt32(Console.ReadLine());
      
      int res = 1;
      for(int i = 0; i < pow; i++){
          res = res * num;
      }
      
      Console.WriteLine(res);
      
    }
}