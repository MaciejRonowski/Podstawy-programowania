using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisać program wczytujący promień koła i wypisujący na ekranie jego pole i obwód.
             */
            int r;
            Console.WriteLine("Podaj promień koła:");
            r=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pole koła wynosi: {0}", Math.PI * r * r);
            Console.WriteLine("Obwód koła wynosi: {0}", 2 * Math.PI * r);
            Console.ReadKey(true);
        }
    }
}
