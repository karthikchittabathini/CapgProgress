using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Please enter the Name");
      string name = Console.ReadLine();
      
      int vowels = 0;
      int constants = 0;
      
      //char[] vowelsArray = new char[]{'a','e','i','o','u','A','E','I','O','U'};
      string VowelsAll = "aeiouAEIOU";
      foreach(char c in name){
          if(VowelsAll.Contains(c)){
              vowels += 1;
          }
          else{
              constants += 1;
          }
      }
      
      Console.WriteLine("Vowels :" + vowels);
      Console.WriteLine("Constants :"+ constants);
    }
}
