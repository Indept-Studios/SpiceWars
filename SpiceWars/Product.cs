using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceWars
{
    class Product
    {
        public string Name { get; private set; }
        public int Price { get; set; }

        public Product(string name,int price)
        {
            Name = name;
            Price = price;
        }
    }
}
