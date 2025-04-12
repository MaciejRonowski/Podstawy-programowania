using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisać program wczytujący długości boków prostopadłościanu i wypisujący na ekranie jego
             objętość i pole całkowite.
             */
            int a, b, c;
            Console.WriteLine("Podaj długość prostopadłościanu:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wysokość prostopadłościanu:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj szerokość prostopadłościanu:");
            c = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Objętość prostopadłościanu wynosi: {0}", a * b * c);
            Console.WriteLine("Pole prostopadłościanu wynosi: {0}", (2 * a * b) + (2 * b * c) + (2 * a * c));
            Console.ReadKey(true);
        }
    }
}
