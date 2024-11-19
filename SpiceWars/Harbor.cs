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

        public Product[] goods;
        public int[] stock = new int[Config.Default.productCount];

        public Harbor(string name)
        {
            Name = name;
            goods = Manager.FillGoods();
            stock = Manager.GetStockValue(stock);
            Manager.GetProductPriceValue(goods);
        }
    }
}
