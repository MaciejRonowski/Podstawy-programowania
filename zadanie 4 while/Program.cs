using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i, j;
            Console.WriteLine("Podaj liczbę wierszy (n):");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę kolumn (k):");
            k = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while(i<=n)//liczba wierszy
            {
                j = 1;
                while(j<=k)//liczba gwiazdek
                {
                    Console.Write("*");
                    j++;
                }//while j
                Console.WriteLine(""); //nowa linia
                i++;
            }//while i
            Console.ReadKey(true);
        }
    }
}
