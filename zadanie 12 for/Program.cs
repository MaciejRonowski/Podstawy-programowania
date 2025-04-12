using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_12_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for.
             */
            int n, i, j;
            Console.Write("Podaj n:");
            n=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) //liczba wierszy
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j*i);
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
    }
}
