using Banking;

class Program 
{
    public delegate void Transactions(double money);

    public delegate void CheckMessages();

    public static void Main(String[] args)
    {
        Console.WriteLine("------------ Hello, welcome to CHK Banking ---------------");

        Account chk = new Account(12345,"Karthik");

        // Initialize the delegates
        Transactions deposit = chk.Deposit;
        Transactions withdraw = chk.Withdraw;

        CheckMessages cm1 = chk.ZeroBalanceMessage;
        CheckMessages cm2 = chk.UnderBalance;
        CheckMessages chkmessages = cm1 + cm2;

        deposit(1700);
        withdraw(1300);
        chkmessages();


    }

}

