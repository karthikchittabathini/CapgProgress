using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{

    interface ICloneable
    {
        void CloneArray();
    }
    public class MyStack : ICloneable
    {
        // declare a integer array
        int[] MyArray = new int[5];
        int[] dummy = new int[5];


        //Console.WriteLine(MyArray.Length);
        int top = -1;
        // push into the integer array
        public void push(int a)
        {
            if (top < 4)
            {
                top = top + 1;
                MyArray[top] = a;
            }
            else
            {
                Console.WriteLine("OPPS!, The Array is Full");
            }
        }

        // pop from the integer array
        public void pop()
        {
            if (top >= 0)
            {
                MyArray[top] = 0;
                top = top - 1;
            }
            else
            {
                Console.WriteLine("OPPS!, The Array is Empty");
            }
        }

        // display the Array
        public void display()
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
        }

        //return array
        int[] ReturnArray()
        {
            return MyArray;
        }

        // display the dummy array
        public void DummyArrayDisplay()
        {
            for (int i = 0; i < dummy.Length; i++)
            {
                Console.WriteLine(dummy[i]);
            }
        }

        public void CloneArray()
        {
            dummy = MyArray;
        }
    }
}
