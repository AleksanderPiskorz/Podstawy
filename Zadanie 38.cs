using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_38

    {
        public static void Wykonaj()
        // 38 Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwracaobliczoną wartość pola koła.Napisz program wykorzystujący funkcję pole_kola.
        {
            static double pole_kola(double r)
            {
                return Math.PI * r * r;
            }

            static void Main(string[] args)
            {
                double promien;

                Console.Write("Podaj promień koła: ");
                promien = double.Parse(Console.ReadLine());

                Console.WriteLine("Pole koła = " + pole_kola(promien));
            }
    }
}
