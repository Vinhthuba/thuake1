using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuake
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lp = new Laptop();
            Book book = new Book();

            lp.Hienthi();
            book.Hienthi();
        }
    }
}
