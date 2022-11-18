using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }


        public Account(int num, string name, double amount = 0)
        {
            this.AccountNumber = num;
            this.CustomerName = name;
            this.Balance = amount;      
        }

        public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
            Console.WriteLine("The balance in your account " + this.Balance);
        }

        public void Withdraw(double amount)
        {
            this.Balance = this.Balance - amount;
            Console.WriteLine("The balance in your account " + this.Balance);
        }
        

        public void ZeroBalanceMessage()
        {
            if(this.Balance == 0)
            {
                Console.WriteLine("The Balance on your account is zero");
            }
        }

        public void UnderBalance()
        {
            if(this.Balance < 500)
            {
                Console.WriteLine("The Balance on your account is UnderBalance. So, please make sure the balance is above 500");
            }
        }
    }
}
