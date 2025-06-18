using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_36

    {
        public static void Wykonaj()
        // 36 Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbamicałkowitymi.Napisz program wykorzystujący funkcję suma.
        {
            int x, y;

            Console.Write("Podaj pierwszą liczbę: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma = " + suma(x, y));
        }
    }
}
