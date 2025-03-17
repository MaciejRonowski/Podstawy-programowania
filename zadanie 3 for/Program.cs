using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, suma = 0;
            Console.WriteLine("Podaj liczbę n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= n; a++)
                suma += a; //suma=suma+a
            Console.WriteLine("1+...+{0}={1}", n, suma);
            Console.ReadKey(true); //pauza
        }
    }
}
