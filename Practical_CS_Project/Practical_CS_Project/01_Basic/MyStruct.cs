using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_CS_Project._01_Basic
{
    struct MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class MyStruct
    {
        static void Main()
        {
            MyPoint a = new MyPoint(10, 20); // MyPoint 객체 생성
            MyPoint b = a; // a를 b에 대입한다.
            Console.WriteLine("a : ({0},{1})", a.X, a.Y);
            Console.WriteLine("b : ({0},{1})", b.X, b.Y);
            a.X = 80;
            Console.WriteLine("a : ({0},{1})", a.X, a.Y);
            Console.WriteLine("b : ({0},{1})", b.X, b.Y);
        }
    }
}
