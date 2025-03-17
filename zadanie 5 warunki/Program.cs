using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Podaj rok:");
            rok = Convert.ToInt32(Console.ReadLine());
            if ((rok % 4 == 0) && (rok % 100 != 0) || (rok % 400 == 0))
                Console.WriteLine("Rok {0} jest przystępny", rok);
            else
                Console.WriteLine("Rok {0} nie jest przystępny", rok);
            Console.ReadKey(true); //pauza
        }
    }
}
