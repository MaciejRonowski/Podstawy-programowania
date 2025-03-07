using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("Podaj a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b= ");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("Suma wynosi: {0}", suma);
            Console.WriteLine("Różnica wynosi: {0}", roznica);
            Console.WriteLine("Iloczyn wynosi: {0}", iloczyn);
            Console.WriteLine("Iloraz wynosi: {0}", iloraz);
            Console.ReadKey(true); //pauza
        }
    }
}
