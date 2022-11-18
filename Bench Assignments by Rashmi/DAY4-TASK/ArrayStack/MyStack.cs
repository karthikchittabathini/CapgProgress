using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayStack;

namespace ArrayStack
{
    //StackException se = new StackException();

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
            try
            {
                top = top + 1;
                MyArray[top] = a;
            }
            catch (IndexOutOfRangeException ex)
            {
               throw new StackFullException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        }

        // pop from the integer array
        public void pop()
        {
            try
            {
                MyArray[top] = 0;
                top = top - 1;
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new StackEmptyException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
