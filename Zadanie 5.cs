using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{
    internal class Zadanie_5 //5. Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka.
    {
        public static void Wykonaj()
        {
            Console.Write("Podaj promień podstawy stożka (r): ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Podaj wysokość stożka (h): ");
            double h = double.Parse(Console.ReadLine());

            double l = Math.Sqrt(r * r + h * h); // długość tworzącej
            double objetosc = (1.0 / 3.0) * Math.PI * r * r * h;
            double poleCalkowite = Math.PI * r * r + Math.PI * r * l;

            Console.WriteLine($"Objętość stożka: {objetosc:F2}");
            Console.WriteLine($"Pole całkowite stożka: {poleCalkowite:F2}");

            Console.ReadKey(true);
        }
    }
}
