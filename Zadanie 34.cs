using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_34

    {
        public static void Wykonaj()
        // 34 Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.
        {
            int n = int.Parse(Console.ReadLine());
            string binarnie = Convert.ToString(n, 2);
            Console.WriteLine($"Binarnie: {binarnie}");
        }
    }
}
