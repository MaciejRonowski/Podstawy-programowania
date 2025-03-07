using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
                Console.WriteLine("Liczba jest nieparzysta");
            Console.ReadKey(true); //pauza
        }
    }
}
