using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_20

    {
        public static void Wykonaj()
        //20NWczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który ie jest trójkątem prostokątnym.
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int gwiazdki = 2 * i - 1;
                int spacje = n - i;
                Console.WriteLine(new string(' ', spacje) + new string('*', gwiazdki));
            }
        }
    }
}
