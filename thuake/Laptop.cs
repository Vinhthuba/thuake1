using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Laptop : Product
{
    public string Ram;
    public string Chip;

    public Laptop()
    {
        Ram = "8 GB";
        Chip = "core i5";
        Id = 1;
        Name = "Dell vostro";
        Price = "125$";
    }
      public override void Hienthi()
    {
        Console.WriteLine($"{Id} {Name} {Ram} {Chip} {Price}");
    }
}
