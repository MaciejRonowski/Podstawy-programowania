using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            int miesiac;
            Console.WriteLine("Podaj numer miesiąca:");
            miesiac = Convert.ToInt32(Console.ReadLine());
            if (miesiac == 1)
                Console.WriteLine("Styczeń");
            else if (miesiac == 2) Console.WriteLine("Luty");
            else if (miesiac == 3) Console.WriteLine("Marzec");
            else if (miesiac == 4) Console.WriteLine("Kwiecień");
            else if (miesiac == 5) Console.WriteLine("Maj");
            else if (miesiac == 6) Console.WriteLine("Czerwiec");
            else if (miesiac == 7) Console.WriteLine("Lipiec");
            else if (miesiac == 8) Console.WriteLine("Sierpień");
            else if (miesiac == 9) Console.WriteLine("Wrzesień");
            else if (miesiac == 10) Console.WriteLine("Październik");
            else if (miesiac == 11) Console.WriteLine("Listopad");
            else if (miesiac == 12) Console.WriteLine("Grudzień");
            else Console.WriteLine("Nie ma takiego miesiąca!");
            Console.ReadKey(true); //pauza
        }
    }
}
