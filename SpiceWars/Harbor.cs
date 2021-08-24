using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceWars
{
    class Harbor
    {
        public string Name { get; private set; }
        public string[] goods = new string[] { "Product A", "Product B", "Product C", "Product D", "Product E" };
        public int[] stock = new int[5];

        public Random rnd = new Random();
        
        public Harbor(string name)
        {
            Name = name;
            for (int i = 0; i < stock.Length; i++)
            {
                stock[i] = rnd.Next(0, 51);
            }
        }
    }
}
