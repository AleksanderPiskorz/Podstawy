using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_29

    {
        public static void Wykonaj()
        // 29  Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,dla 2 – pola kwadratu, a dla 3 – pola trójkąta.Program powinien pytać użytkownika, którepole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0 (zero)
        {
            int wybor;

            do
            {
                Console.WriteLine("1 - Pole prostokąta");
                Console.WriteLine("2 - Pole kwadratu");
                Console.WriteLine("3 - Pole trójkąta");
                Console.WriteLine("0 - Wyjście");
                Console.Write("Wybierz opcję: ");
                wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        Console.Write("Podaj długość: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Podaj szerokość: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Pole prostokąta: {a * b}");
                        break;
                    case 2:
                        Console.Write("Podaj bok: ");
                        double bok = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Pole kwadratu: {bok * bok}");
                        break;
                    case 3:
                        Console.Write("Podaj podstawę: ");
                        double podstawa = double.Parse(Console.ReadLine());
                        Console.Write("Podaj wysokość: ");
                        double wysokosc = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Pole trójkąta: {(podstawa * wysokosc) / 2}");
                        break;
                    case 0:
                        Console.WriteLine("Zakończono program.");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }

                Console.WriteLine();
            } while (wybor != 0);
        }
    }
}
