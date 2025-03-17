using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            for (a = 11; a <= 33; a++)
                Console.Write("{0}, ", a);
            Console.ReadKey(true); //pauza
        }
    }
}
