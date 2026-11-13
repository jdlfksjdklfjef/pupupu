using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ProductLoader.LoadFromCsv("products.csv");

            foreach (Product product in products) 
            {
                Console.WriteLine(product);
            }
        }
    }
}
