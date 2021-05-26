using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        static void Main(string[] args)
        {
            double p, m, v;
            try
            {
                Console.Write("Введите массу: ");
                string Buf = Console.ReadLine();
                m = double.Parse(Buf);
                Console.Write("Введите объём: ");
                Buf = Console.ReadLine();
                v = double.Parse(Buf);
                p = SafeDivision(m, v);
                Console.WriteLine("Плотность: " + p + " кг/м^3");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
            catch
            {
                Console.WriteLine("Неопознанное исключение");
            }
            Console.ReadKey();
        }
    }
}
