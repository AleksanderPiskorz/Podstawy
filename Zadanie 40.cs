using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_40

    {
        public static void Wykonaj()
        // 40 Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcjapowinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanieutworzonej funkcji.


        {
            static int czy_pierwsza(uint n)
            {
                if (n < 2)
                    return 0;

                for (uint i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                        return 0;
                }

                return 1;
            }

            static void Main(string[] args)
            {
                uint liczba;

                Console.Write("Podaj liczbę: ");
                liczba = uint.Parse(Console.ReadLine());

                if (czy_pierwsza(liczba) == 1)
                    Console.WriteLine("Liczba jest pierwsza");
                else
                    Console.WriteLine("Liczba nie jest pierwsza");
            }
    }
}
