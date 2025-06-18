using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_11

    {
        public static void Wykonaj()
        // 11.  Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.
        {
            double a, b, c, d, e, min, max;

            Console.Write("Podaj liczbę nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 4: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 5: ");
            e = Convert.ToDouble(Console.ReadLine());

            min = Math.Min(Math.Min(Math.Min(a, b), Math.Min(c, d)), e);
            max = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), e);

            Console.WriteLine("Najmniejsza liczba to: {0}", min);
            Console.WriteLine("Największa liczba to: {0}", max);

            Console.ReadKey(true); // pauza
        }
    }
}
