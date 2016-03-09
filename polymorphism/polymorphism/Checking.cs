using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Checking : Account
    {
        public override void Withdraw()
        {
            if (Balance == 0)
            {
                Console.WriteLine("Sorry, your balance is zero.");
                return;
            }
            else
            {
                base.Withdraw();
            }
        }


    }
}
