using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;

            Console.WriteLine("a * x2 + b * x + c = 0");

            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант: " + d);
            double m = Math.Sqrt(d);

            if (d >= 0)
            {
                double x1 = (-b) + m / 2 * a;
                Console.WriteLine("Первый корень: " + x1);
                double x2 = (-b) - m / 2 * a;
                Console.WriteLine("Второй корень: " + x2);
            } else
            {
                Console.WriteLine("Дискриминант меньше нуля!!! Корней нет!!!");
            }

            Console.ReadKey();
        }
    }
}
