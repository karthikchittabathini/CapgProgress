using System;
class HelloWorld {
  static void Main() {
     
      Console.WriteLine("Enter the string : ");
      string name = Console.ReadLine();
      string distinct = "";
      string repeated = "";
      foreach(char c in name){
          int count = 0;
          foreach(char x in name){
              if(c == x){
                  count += 1;
              }
          }
          if(count == 1){
              distinct += c.ToString();
          }
          else{
              repeated += c.ToString();
          }
      }
      
      Console.WriteLine("Distinct Characters" + distinct);
      Console.WriteLine("Repeated Characters" + repeated);
    }
}
