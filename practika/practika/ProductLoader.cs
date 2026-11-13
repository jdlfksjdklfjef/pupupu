using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace practika
{
    public class ProductLoader
    {
        public List<Product> LoadFromCsv(string filePath)
        {
            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    reader.ReadLine(); 

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(';');

                        if (values.Length == 3)
                        {
                            Product product = new Product();
                            product.SetName(values[0].Trim());
                            product.SetPrice(decimal.Parse(values[1].Trim()));
                            product.GetSoldcount(int.Parse(values[2].Trim()));

                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка чтения файла: " + ex.Message);
            }

            return products;
        }
    }
}