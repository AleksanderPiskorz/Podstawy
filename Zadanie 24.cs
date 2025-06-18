using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_24

    {
        public static void Wykonaj()
        //24Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste zprzedziału[a, b]. Użyj pętli while.
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int i = a;

            while (i <= b)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
