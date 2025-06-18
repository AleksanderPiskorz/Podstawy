using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{
    internal class Zadanie_7 //7. Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia.
    {
        public static void Wykonaj()
        {
            int a, b;
            Console.WriteLine("Podaj pierwszą liczbę całkowitą:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę całkowitą:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{00} / {1} = {2} z resztą {3}", a, b, a / b, a % b);
            Console.ReadKey(true);
        }
    }
}
