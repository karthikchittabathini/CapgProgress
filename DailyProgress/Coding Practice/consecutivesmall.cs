using System;
class HelloWorld {
  static void Main() {
      int[] num = new int[]{5,1,0,2,3,6,9};
      int smallsum = 0;
      if(num.Length >= 2){
          smallsum = num[0] + num[1];
      }
      for(int i = 0; i <num.Length-1; i++)
      {
          if(num[i]+num[i+1] < smallsum)
          {
              smallsum = num[i] + num[i+1];
          }
      }
      
      Console.WriteLine(smallsum);
    }
}