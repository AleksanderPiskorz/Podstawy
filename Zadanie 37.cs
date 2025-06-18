using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_37

    {
        public static void Wykonaj()
        // 37 Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistychzadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.
        {
            static double max(double a, double b)
            {
                if (a > b)
                    return a;
                else
                    return b;
            }

            static void Main(string[] args)
            {
                double x, y;

                Console.Write("Podaj pierwszą liczbę: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("Podaj drugą liczbę: ");
                y = double.Parse(Console.ReadLine());

                Console.WriteLine("Maksimum = " + max(x, y));
            }
    }
}
