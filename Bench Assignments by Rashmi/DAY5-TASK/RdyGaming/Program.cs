using RdyGaming;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("--- Hello welcome to RDY Gaming ---");

        Team India = new Team();

        foreach(var x in India.PlayerList)
        {
            Console.WriteLine(x.Name + " - " + x.RunsScored);
        }
    }
}