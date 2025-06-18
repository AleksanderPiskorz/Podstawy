using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_33

    {
        public static void Wykonaj()
        // 33 . Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekraniesumę wczytanych liczb.
        {
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];
            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
                suma += liczby[i];
            }

            Console.WriteLine($"Suma: {suma}");
        }
    }
}
