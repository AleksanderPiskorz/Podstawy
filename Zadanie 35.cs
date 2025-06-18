using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_35

    {
        public static void Wykonaj()
        // 35 . Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętliforeach.
        {
            string[] dni = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };

            foreach (string dzien in dni)
            {
                Console.WriteLine(dzien);
            }
        }
    }
}
