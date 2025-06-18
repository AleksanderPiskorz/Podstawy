using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_32

    {
        public static void Wykonaj()
        // 32 Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco iwypisujący posortowane liczby na ekranie.
        {
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];

            for (int i = 0; i < n; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(liczby);

            foreach (int x in liczby)
            {
                Console.WriteLine(x);
            }
        }
    }
}
