using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, suma=0;
            Console.WriteLine("Podaj a (a<b):");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b (a<b):");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while(i<=b)
            {
                suma += i;
                i++;
            }//while i
            Console.WriteLine("{0}+...+{1}={2}", a, b, suma);
            Console.ReadKey(true); //pauza
        }
    }
}
