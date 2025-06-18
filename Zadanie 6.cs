using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{
    internal class Zadanie_6 //6. Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz

    {
        public static void Wykonaj()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            double suma = liczba1 + liczba2;
            double roznica = liczba1 - liczba2;
            double iloczyn = liczba1 * liczba2;
            double iloraz = liczba2 != 0 ? liczba1 / liczba2 : double.NaN;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Różnica: " + roznica);
            Console.WriteLine("Iloczyn: " + iloczyn);
            if (liczba2 != 0)
                Console.WriteLine("Iloraz: " + iloraz);
            else
                Console.WriteLine("Iloraz: Nie można dzielić przez 0");

            Console.ReadKey(true);
        }
    }
}
