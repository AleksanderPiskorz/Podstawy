using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_25

    {
        public static void Wykonaj()
        //25 Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n iwypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n). Użyj pętli while.
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= n)
            {
                Console.WriteLine(2 * i - 1);
                i++;
            }
        }
    }
}
