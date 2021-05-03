using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project._01_Basic
{
    class DT
    {
        class MyClass
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        struct MyStruct
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main()
        {
            DateTime date = new DateTime(2021, 05, 03);

            int year = date.Year;

            DateTime daysAfter10 = date.AddDays(10);

            Console.WriteLine("설정한 날짜 : " + date);
            Console.WriteLine("설정한 날짜의 년도 : " + year);
            Console.WriteLine("설정한 날짜의 10일 후 날짜 : " + daysAfter10);

            MyClass myClass = new MyClass { X = 1, Y = 2 };

            MyStruct myStruct = new MyStruct { X = 1, Y = 2 };

        }
    }
}
