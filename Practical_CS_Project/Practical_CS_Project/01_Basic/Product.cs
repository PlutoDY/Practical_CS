using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project._01_Basic
{
    public class Product
    {
        // 상품 코드
        public int Code { get; private set; }

        // 상품 이름
        public string Name { get; private set; }

        // 상품 가격(세금이 붙지 않은 가격)
        public int Price { get; private set; }

        public Product(int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }

        static void Main()
        {
            Product yakkwa = new Product(12, "약과", 180);
            Product chapssal = new Product(235, "찹쌀떡", 160);


            int yakkwaPrice = yakkwa.Price;
            int yakkwaTaxIncluded = yakkwa.GetPriceIncludingTax();


            Console.WriteLine("약과 가격(세금 미포함) : " +  yakkwaPrice);
            Console.WriteLine("약과 가격(세금 포함) : " + yakkwaTaxIncluded);

            Console.WriteLine();
            Console.WriteLine(chapssal.Name + " 가격(세금 포함) : " + chapssal.GetPriceIncludingTax()+"\\");
        }
    }

}
