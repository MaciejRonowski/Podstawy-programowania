using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_13_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta
             prostokątnego jak na poniższym przykładzie. Użyj pętli for.
            Dla n=5 powinien zostać narysowany trójkąt:
            X
            XX
            X X
            X  X
            XXXXX
             */
            int n, i;
            Console.Write("Podaj liczbę naturalną większą niż 4: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("X");
                }
                else if (i == n)
                {
                    Console.WriteLine("X", n);
                }
                else
                {
                    Console.WriteLine("X" + " ", i - 2 + "X");
                }
            }
        }
    }
}