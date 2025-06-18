using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_21

    {
        public static void Wykonaj()
        // 21. Spośród liczb od 1 do 100 wypisz na ekranie wszystkie liczby podzielne przez 13. Użyj pętlifor
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 13 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
