using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project.CS_Frist_Program.Calculating_Revenue
{
    public class Sale
    {
        public string ShopName { get; set; }
        
        public string ProductCategory { get; set; }

        public int Amount { get; set; }

        static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines)
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
}
