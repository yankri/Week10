using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Savings : Account
    {
        public override void Withdraw()
        {
            if (Balance > 300)
            {
                double currentAvailable = Balance - 300;
                Console.WriteLine("Currently Available for withdrawal: ${0}", currentAvailable);
                base.Withdraw();
            }
            else
            {
                Console.WriteLine("Current balance must be greater than $300.00 to withdraw.");
            }
        }


    }
}
