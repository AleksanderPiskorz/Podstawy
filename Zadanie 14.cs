using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_14

    {
        public static void Wykonaj()
        // 14.Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej odpowiednik rzymski.
        {
            int liczba;
            Console.Write("Podaj liczbę arabską od 1 do 3999: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba < 1 || liczba > 3999)
            {
                Console.WriteLine("Liczba poza zakresem!");
            }
            else
            {
                string[] tys = { "", "M", "MM", "MMM" };
                string[] set = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] dzies = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] jedn = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

                string rzymska = tys[liczba / 1000] +
                                 set[(liczba % 1000) / 100] +
                                 dzies[(liczba % 100) / 10] +
                                 jedn[liczba % 10];

                Console.WriteLine("Liczba rzymska: " + rzymska);
            }

            Console.ReadKey(true); // pauza
        }
    }
}
