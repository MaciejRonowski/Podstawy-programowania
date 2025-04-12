using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_10_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7. Ilość liczb
             wczytaj z klawiatury.
             */
            int n, i;
            Console.WriteLine("Podaj n:");
            n=Convert.ToInt32(Console.ReadLine());
            for (i = 0, i > n, i++)
            { Console.Write("{0}, ", i * 7);
            }
            Console.ReadKey(true);

        }
    }
}
