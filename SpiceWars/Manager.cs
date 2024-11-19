using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceWars
{
    class Manager
    {
        private static string[] productNames = new string[] { "Pfeffer", "Salz", "Curry", "Paprika", "Zimt" };
        private static string[] portNames = new string[] { "Köln", "Leverkusen", "Kerpen", "Brühl", "Frankfurt" };
        
        private static int[] prices = new int[5];
        
        private static Product[] products = new Product[Config.Default.productCount];
        private static Harbor[] ports = new Harbor[Config.Default.portCount];

        static Random rnd = new Random();

        /// <summary>
        /// Fills all goods in the harbor stock on initalization 
        /// </summary>
        /// <returns></returns>
        public static Product[] FillGoods()
        {
            for (int i = 0; i < Config.Default.productCount; i++)
            {
                products[i]= new Product(productNames[i], prices[i]);
            }
            return products;
        }

        /// <summary>
        /// Creates all harbos on initalization 
        /// </summary>
        /// <returns></returns>
        public static Harbor[] FillPorts()
        {
            for (int i = 0; i < Config.Default.portCount; i++)
            {
                ports[i] = new Harbor(portNames[i]);
            }
            return ports;
        }

        /// <summary>
        /// Generates a random value for the amount of raw goods
        /// </summary>
        /// <param name="stock"></param>
        /// <returns></returns>
        public static int[] GetStockValue(int[] stock)
        {
            for (int i = 0; i < stock.Length; i++)
            {
                stock[i] = rnd.Next(0, 51);
            }
            return stock;
        }

        public static void GetProductPriceValue(Product[] goods)
        {
            for (int i = 0; i < goods.Length; i++)
            {
                goods[i].Price = rnd.Next(1, 11);
            }
        }
    }
}
