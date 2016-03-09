using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay
{
    class DVD : Resource
    {
        public override void ViewTitle()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Length: {0} minutes", Length);
            Console.WriteLine("Status: {0}", Status);
            Console.ReadKey();
        }

        public override void AddTitle()
        {
            Console.WriteLine("Enter the title you want to add: ");
            string input = Console.ReadLine();
            Title = input;
            Status = "Available";

            Console.WriteLine("Enter the ISBN: ");
            string num = Console.ReadLine();
            ISBN = num;

            Console.WriteLine("Enter the length in minutes: ");
            string minutes = Console.ReadLine();
            Length = uint.Parse(minutes);
            Console.ReadKey();
        }

    }
}
