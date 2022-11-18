using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesessions
{
    public class swapnumbers
    {
        public void swapping(int a, int b)
        {

            Console.WriteLine("--- Numbers before Swapping --- ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("--- Numbers after Swapping --- ");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);

        }
    }
}
