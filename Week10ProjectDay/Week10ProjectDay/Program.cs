using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Magazine mags = new Magazine();
            DVD movies = new DVD();

            book.AddTitle();
            book.ViewTitle();

            mags.AddTitle();
            mags.ViewTitle();

            movies.AddTitle();
            movies.ViewTitle();

            book.CheckOut();
            book.ViewTitle();
            book.CheckIn();
            book.ViewTitle();

            mags.CheckOut();
            mags.ViewTitle();
            mags.CheckIn();
            mags.ViewTitle();

            movies.CheckOut();
            movies.ViewTitle();
            movies.CheckIn();
            movies.ViewTitle();
        }
    }
}
