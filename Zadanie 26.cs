using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_C_.Wprowadzenie
{ 
    internal class Zadanie_26

    {
        public static void Wykonaj()
        //26Napisz program wczytujący dwie liczby całkowite a oraz b (a<b) i obliczający sumę kolejnychliczb całkowitych począwszy od liczby a, a skończywszy na liczbie b.Obliczoną sumę wypiszna ekranie. Użyj pętli while. Np.dla a = -2 i b = 5 obliczamy sumę (-2)+(-1)+0+1+2+3+4+5.
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int suma = 0;
            int i = a;

            while (i <= b)
            {
                suma += i;
                i++;
            }
            Console.WriteLine($"Suma: {suma}");
        }
    }
}
