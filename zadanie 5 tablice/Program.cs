using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym
            int[] tab = new int[1000];
            int i = 0, j, n;
            Console.WriteLine("Podaj liczbę naturalną:");
            n = Convert.ToInt32(Console.ReadLine());
            while((n/2!=0)|| ((n/2==0) && (n%2!=0)))
            {
                tab[i++] = n % 2;
                n /= 2;
            }
            //wypisuje w odwrotnej kolejności
            for (j=i-1; j>=0; j--)
                Console.WriteLine(tab[j]);
            Console.ReadKey(true); //pauza

        }
    }
}
