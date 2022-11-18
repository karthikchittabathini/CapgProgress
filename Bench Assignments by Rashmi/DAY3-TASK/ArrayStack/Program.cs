using ArrayStack;


class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---- Hello welcome to my stack -----");
        // declare a integer array

        int[] MyArray = new int[5];


        //Console.WriteLine(MyArray.Length);



        bool iter = true;
        MyStack s = new MyStack();




        while (iter)
        {
            Console.WriteLine("To push to array - press 1");
            Console.WriteLine("To pop from array - press 2");
            Console.WriteLine("To display the array - press 3");
            Console.WriteLine("To display the dummy array - press 4");
            Console.WriteLine("To exit - press 0");

            Console.WriteLine("Please enter a input");
            int ans = Convert.ToInt32(Console.ReadLine());

            switch (ans)
            {
                case 0:
                    iter = false;
                    break;
                case 1:
                    Console.WriteLine("Please enter the value to push/add");
                    int val = Convert.ToInt32(Console.ReadLine());
                    s.push(val);
                    break;
                case 2:
                    s.pop();
                    break;
                case 3:
                    s.display();
                    break;
                case 4:
                    s.CloneArray();
                    s.DummyArrayDisplay();
                    break;
                default:
                    Console.WriteLine("please enter a valid option");
                    break;
            }
        }
    }


}