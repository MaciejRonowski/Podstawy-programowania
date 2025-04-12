using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy
             da się z tych odcinków zbudować trójkąt, czy też nie.
             */
            int a, b, c;
            Console.WriteLine("Podaj pierwszy odcinek:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugi odcinek:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzeci odcinek:");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a+b>=c)||(a+c<=b)||(b+c<=a))
                Console.WriteLine("Z tych odcinków da się zbudować trójkąt.");
            else Console.WriteLine("Z tych odcinków nie da się zbudować trójkąta!");
            Console.ReadKey(true);
        }
    }
}
