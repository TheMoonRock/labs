using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("D:\\Lab6.txt");
            string s = f.ReadLine(); int nm = Convert.ToInt32(s);
            string q = f.ReadLine(); int nj = Convert.ToInt32(q);
            string w = f.ReadLine(); int nk = Convert.ToInt32(w);
            string e = f.ReadLine(); int nh = Convert.ToInt32(e);
            string r = f.ReadLine(); int nl = Convert.ToInt32(r);
            string t = f.ReadLine(); int np = Convert.ToInt32(t);
            const int n = 6;
            int[] a = new int[n] { nm, nj, nk, nh, nl, np };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < n; ++i)
                Console.Write(" \t " + a[i]);
                Console.WriteLine();
                long sum = 0;
                int num = 0;
            for ( int i = 0; i < n; ++i)
                if ( a [i] > 0)
                {
                    sum += a[i];
                    ++num;
                }
            Console.WriteLine( "Сумма положительных = " + sum );
            Console.WriteLine("Кол-во положительных = " + num );
            int max = a[0];
            for (int i = 1; i < n; ++i)
                if (a[i] > max) max = a[i];
            int min = a[0];
            for (int i = 1; i < n; ++i)
                if (a[i] < min) min = a[i];
            int solution = max * min;
            Console.WriteLine( "Произведение = " + solution);
            Console.ReadKey();
        }
    }
}
