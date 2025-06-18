using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{
    internal class Zadanie_4 // 4. Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
    {
        public static void Wykonaj()
        {
            double a, b;
            Console.WriteLine("Podaj długość boku a prostokąta:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długość boku b prostokąta:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole prostokąta wynosi: {a * b}");
            Console.WriteLine("Obwód prostokąta wynosi: {2 * (a + b)}");   
            Console.ReadKey(true);
        }
    }
}
