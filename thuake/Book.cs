using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book : Product
{
    public string Author;

    public Book()
    {
        Author = "Vinh";
    }
    public override void Hienthi()
    {
        Console.WriteLine($"{Id} {Name} {Author} {Price}");

    }
}
