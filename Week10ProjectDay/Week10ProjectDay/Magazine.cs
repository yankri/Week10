using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay
{
    class Magazine : Resource
    {
        public override void CheckOut()
        {
            Status = "Checked Out";

            DateTime time = new DateTime(2016, 3, 8, 8, 0, 0);

            Console.WriteLine("The item is due " + time.AddDays(2));

            Console.WriteLine("{0} has been checked out.", Title);
            Console.ReadKey();
        }
    }
}
