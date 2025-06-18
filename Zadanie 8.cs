using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_8

    {
        public static void Wykonaj()
        // 8. Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację, czy jest to liczba parzysta, czy też nieparzysta.
        {
            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Liczba {0} jest parzysta.", a);
            else
                Console.WriteLine("Liczba {0} jest nieparzysta.", a);

            Console.ReadKey(true); // pauza
        }
    }
}
