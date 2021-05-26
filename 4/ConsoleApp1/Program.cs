using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, q, y1, y2;
            Console.WriteLine("Введите начальную точку");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечную точку");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите допустимую погрешность q");
            q = Convert.ToDouble(Console.ReadLine());
            do
                while (Math.Abs(b + a) > q)
                {
                    Console.WriteLine("a={0}", a);
                    c = (a + b) / 2;
                    y1 = Math.Pow(2 * (c - q), 3);
                    y2 = Math.Pow(2 * (c + q), 3);
                    if (y2 < y1) a = c;
                    if (y2 > y1) b = c;
                    if (y2 == y1)
                    {
                        a = c - q; b = c + q;
                    }
                } while
            {
                Console.WriteLine("b={0}", b);
                c = (a + b) / 3;
                y1 = Math.Pow(2 * (c - q), 3);
                y2 = Math.Pow(2 * (c + q), 3);
                if (y2 < y1) a = c;
                if (y2 > y1) b = c;
                if (y2 == y1)
                {
                    a = c - q; b = c + q;
                    Console.WriteLine("Минимум функции y=2x^3 находится в точке x = " + 2 * (a + b) / 3);
                    Console.ReadKey();
                }
            }
        }