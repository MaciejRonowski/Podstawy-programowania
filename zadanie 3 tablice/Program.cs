using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i wypisujący posortowane liczby na ekranie.
            int[] tab = new int[1000];
            int i, j; //liczniki pętli
            int n, tmp; //ilość elementów tmp-zmienna pomocnicza 
            Console.WriteLine("Podaj liczbę n<=1000:"); //wczytywanie n
            n = Convert.ToInt32(Console.ReadLine());
            //wczytuję n elementów
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]:", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            //sortowanie elementów
            for(i=0; i < n; i++)
                for (j = i+1 ;j < n; j++)
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }
            //wyświetlanie elementów
            Console.Write("Elementy tablicy:");
            for(i=0;i<n;i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
