using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 100; i++)
                if (i % 13 == 0) 
                    Console.Write("{0}, ",i);
            Console.ReadKey(true);//pauza
        }
    }
}
