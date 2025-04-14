using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_funkcje
{
    internal class Program
    {
        static double pole_kola(double r)
        { 
            return Math.PI * r * r; 
        }
        static void Main(string[] args)
        {
            /*
             Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
             obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.
             */
            Console.WriteLine("Dla r = 1,5 Pole = {0}", pole_kola(1.5));
            Console.ReadKey(true);
        }
    }
}
