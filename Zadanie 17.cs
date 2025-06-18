using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_17

    {
        public static void Wykonaj()
        // 17. Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy 1+2+…+n.Do obliczenia wartości sumy użyj pętli for.
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            Console.WriteLine($"Suma: {suma}");
        }
    }
}
