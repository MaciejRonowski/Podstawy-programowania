using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_11_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać
             od użytkownika. Przykładowo dla n=3 należy obliczyć sumę 1+3+5.
             */
            int n, i, suma, liczba;
            Console.Write("Podaj ilość liczb nieparzystych:");
            n=Convert.ToInt32(Console.ReadLine());
            suma = 0;
            liczba = 1;
            for (i = 0; i < n; i++)
            {
                    suma += liczba;
                    Console.Write(liczba);
                if (i < n - 1)
                {
                    Console.Write(" + ");
                }
                    liczba += 2;
            }
            Console.WriteLine(" = {0}", suma);
            Console.ReadKey(true);

        }
    }
}
