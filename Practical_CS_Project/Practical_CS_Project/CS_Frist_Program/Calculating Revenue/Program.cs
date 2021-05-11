using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practical_CS_Project.CS_Frist_Program.Calculating_Revenue
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesCounter sales = new SalesCounter(ReadSales("sales.csv"));
            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string, int> obj in amountPerStore)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }

            return;
        }

        static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] item = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = int.Parse(item[2])
                };
                sales.Add(sale);
            }

            return sales;
        }
    }

    public class SalesCounter{
        private List<Sale> _sales;

        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }

        public Dictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales)
            {
               if (dict.ContainsKey(sale.ShopName))
               {
                    dict[sale.ShopName] += sale.Amount;
               }
               else
               {
                    dict[sale.ShopName] = sale.Amount;
               }
            }

            return dict;
        }
    }
}
