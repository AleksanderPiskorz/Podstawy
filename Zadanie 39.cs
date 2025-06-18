using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_39

    {
        public static void Wykonaj()
        // 39 Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jakoargument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr
        {
            static int ile_cyfr(uint n)
            {
                int licznik = 0;
                do
                {
                    licznik++;
                    n = n / 10;
                } while (n > 0);

                return licznik;
            }

            static void Main(string[] args)
            {
                uint liczba;

                Console.Write("Podaj liczbę naturalną: ");
                liczba = uint.Parse(Console.ReadLine());

                Console.WriteLine("Liczba cyfr = " + ile_cyfr(liczba));
            }
    }
}
