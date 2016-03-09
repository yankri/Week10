using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    abstract class Account
    {
        double balance;

        public double Balance { get; set; }

        public virtual void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double amount = double.Parse(Console.ReadLine());
            Balance = Balance - amount;
        }

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            double amount = double.Parse(Console.ReadLine());
            Balance = Balance + amount;
        }

        public void ViewBalance()
        {
            Console.WriteLine(Balance);
        }




    }
}
