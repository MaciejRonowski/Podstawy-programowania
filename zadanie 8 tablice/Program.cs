using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisać program wczytujący ciąg n (1<=n<=1000) liczb naturalnych i wypisujący na ekranie
             wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj
             pętli foreach.
             Wskazówka: Posortuj wczytane liczby, a następnie z tablicy wypisz tylko liczby parzyste.
             */
            int[] tab = new int[1000];
            int n, i, j, tmp;
            Console.Write("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0; i<n; i++)
            {
                Console.Write("Podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }
                }

            }
            int[] tylkoN = new int[n];
            Array.Copy(tab, tylkoN, n);
            foreach (int t in tylkoN)
                    if (t % 2 == 0)
                    {
                        Console.Write(t + " ");
                    }
            Console.ReadKey(true);
        }
    }
}
