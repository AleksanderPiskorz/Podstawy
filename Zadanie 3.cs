using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{
    internal class Zadanie_3 // 3. Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian wczytanej liczby.3. 

    {
        public static void Wykonaj()
        {
            int a;
            Console.WriteLine("Podaj liczbę całkowitą:");
            a = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("a^3={0}", a * a * a);
            Console.ReadKey(true);
        }
    }
}
