using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_16

    {
        public static void Wykonaj()
        // 16. Napisać program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 d opotęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2^10=1024. Do obliczenia wartości wyrażenia użyj pętli for.
        {
            int n = int.Parse(Console.ReadLine());
            int wynik = 1;
            for (int i = 0; i < n; i++)
            {
                wynik *= 2;
            }
            Console.WriteLine($"2^{n}={wynik}");
        }
    }
}
