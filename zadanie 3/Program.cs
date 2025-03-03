using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("a^3={0}", a * a * a);
            Console.ReadKey(true); //pauza
       
        }
    }
}
