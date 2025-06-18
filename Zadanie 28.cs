using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_28

    {
        public static void Wykonaj()
        // 28 . Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartośćzmiennej x, aż przyjmie ona wartość dodatnią.Wczytaną dodatnią wartość liczby x wypisz naekranie.Użyj pętli do-while.
        {
            double x;

            do
            {
                Console.Write("Podaj liczbę dodatnią: ");
                x = double.Parse(Console.ReadLine());
            } while (x <= 0);

            Console.WriteLine($"Wczytano liczbę: {x}");
        }
    }
}
