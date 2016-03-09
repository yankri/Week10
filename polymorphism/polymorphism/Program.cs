using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking checks = new Checking();
            Savings longterm = new Savings();
            checks.Withdraw();
            longterm.Deposit();
            longterm.ViewBalance();
            longterm.Withdraw();
            longterm.ViewBalance();
        }
    }
}
