using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{
    internal class Zadanie_2 //2. Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!".
    {
        public static void Wykonaj()
        {
            string imie;
            Console.WriteLine("Podaj swoje imię:");
            imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}!");
            Console.ReadKey(true);
        }
    }
}
