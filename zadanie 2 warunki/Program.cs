using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnią", a);
            else if (a < 0)
                Console.WriteLine("Liczba {0} jest ujemną", a);
            else
                Console.WriteLine("Liczba jest równa 0");
            Console.ReadKey(true); //pauza

        }
    }
}
