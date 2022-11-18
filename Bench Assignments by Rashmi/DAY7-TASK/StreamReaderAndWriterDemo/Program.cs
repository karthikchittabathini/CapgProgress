class Program
{
    public static void Main(String[] args)
    {
        //stream reader
        //create an instance of stream reader to read from file
        try
        {
            using(StreamReader sr = new StreamReader("D:\\MainFolder\\subfolder1\\demo.txt"))
            {
                string line;
                
                //read and display the lines until the end of the file is reached

                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
        catch(Exception ex)
        {
            Console.WriteLine("The file could not be found");
            Console.WriteLine(ex.Message);
        }

        //stream writer
        //create an instance for the stream writer and add the text
        string[] text = new string[] { "new line 1 added", "new line 2 added" };

        using (StreamWriter sw = new StreamWriter("d:\\mainfolder\\subfolder1\\demo.txt"))
        {
            foreach (var line in text)
            {
                sw.WriteLine(line);
            }
        }
    }
}