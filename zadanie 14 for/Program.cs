using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_14_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisz program znajdujący wszystkie trójki liczb pitagorejskich z zadanego przedziału.
             Np.: dla przedziału [3,5] mamy jedną trójkę: 3, 4, 5 (bo 3^2+4^2=5^2).
             */
            int start, end;

            // Wczytanie przedziału
            Console.Write("Podaj początek przedziału: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("Podaj koniec przedziału: ");
            end = int.Parse(Console.ReadLine());


            Console.WriteLine($"\nTrójki pitagorejskie w przedziale [{start}, {end}]:");

            // Szukanie trójek pitagorejskich
            for (int a = start; a <= end; a++)
            {
                for (int b = a; b <= end; b++) // b zaczyna się od a, żeby uniknąć powtórzeń
                {
                    for (int c = b; c <= end; c++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine($"{a}, {b}, {c}");
                        }
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
