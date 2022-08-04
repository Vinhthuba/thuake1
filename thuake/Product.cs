using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }    
    public string Price { get; set; }

    public  virtual void Hienthi()
    {
        Console.WriteLine($"{Id} {Name} {Price}");
    }
}