using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay
{
    abstract class Resource
    {
        string title;
        string isbn;
        uint length;
        string status;

        public string Title { get; set; }
        public string ISBN { get; set; }
        public uint Length { get; set; }
        public string Status { get; set; }

        public virtual void ViewTitle()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Length: {0} pages", Length);
            Console.WriteLine("Status: {0}", Status);
            Console.ReadKey();
        }

        public virtual void AddTitle()
        {
            Console.WriteLine("Enter the title you want to add: ");
            string input = Console.ReadLine();
            Title = input;
            Status = "Available";

            Console.WriteLine("Enter the ISBN: ");
            string num = Console.ReadLine();
            ISBN = num;

            Console.WriteLine("Enter the length in pages: ");
            string pages = Console.ReadLine();
            Length = uint.Parse(pages);
            Console.ReadKey();
        }

        public virtual void CheckOut()
        {
            Status = "Checked Out";

            DateTime time = new DateTime(2016, 3, 8, 8, 0, 0);

            Console.WriteLine("The item is due " + time.AddDays(3));

            Console.WriteLine("{0} has been checked out.", Title);
            Console.ReadKey();
        }

        public virtual void CheckIn()
        {
            Status = "Available";
            Console.WriteLine("{0} has been checked in.", Title);
            Console.ReadKey();
        }
    }
}
