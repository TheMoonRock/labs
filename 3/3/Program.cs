using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, k;
            char ed;
            bool es;
            Console.WriteLine("Введите первое число: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите знак операции: ");
            ed = (char)Console.Read();
            Console.ReadLine();
            Console.Write("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());
            es = true;
            switch (ed)
            {
                case 'p':
                    k = Math.Pow(x, y);
                    break;
                case 's':
                    k = Math.Sqrt(x);
                    break;
                case '%':
                    k = (100 * y) / x;
                    break;
                default:
                    k = 0;
                    es = false;
                    break;
            }

            if (es)
            {
                Console.WriteLine("Result = " + k);
            }
            else
            {
                Console.WriteLine("Недопустимая операция");
            }


            /* pow степень = сокращение p
             * sqrt корень = сокращение s
             * % будем вычислять так: 100 * y / x = k%
             * 
             * 
             * 
             */


            int f = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                f = f * i;
            }

            Console.WriteLine(f);


            Console.ReadKey();
        }
    }
}
