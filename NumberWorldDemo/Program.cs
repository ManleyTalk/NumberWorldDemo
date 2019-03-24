using System;

namespace NumberWorldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 24;
            int b = 8;

            int c = a + b;//加法运算
            //Console.WriteLine(c);

            ///////////////////////////////////

            c = a - b;//减法运算
           // Console.WriteLine(c);

            c = a * b;//乘法运算
           // Console.WriteLine(c);

            c = a / b;//除法运算
           // Console.WriteLine(c);

            c = a % b;//求余运算
            //Console.WriteLine(c);

            ////////////////////////////////////

            int d = 2;

            int e = a + b * d;
           // Console.WriteLine(e);

            e = (a + b) * d;
            //Console.WriteLine(e);

            /////////////////////////////////

            c = 5 / 3;
            //Console.WriteLine(c);

            c = 5 % 3;
            //Console.WriteLine(c);

            double f = 5;
            double g = 4;
            double h = 2;
            double i = (f + g) / h;
            //Console.WriteLine(i);

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal j = 1.0M / 3.0M;
            Console.WriteLine(j);


            Console.ReadKey();
        }
    }
}
