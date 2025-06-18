using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_31

    {
        public static void Wykonaj()
        // 31 Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytaneliczby w odwrotnej kolejności na ekranie.
        {
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];

            for (int i = 0; i < n; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(liczby[i]);
            }
        }
    }
}
