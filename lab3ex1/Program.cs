using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex1
            Scrieti o functie care va calcula suma cifrelor unui numar.*/
            Console.WriteLine("Introduceti numarul:");
            int numar = int.Parse(Console.ReadLine());

            int sumaCifrelor = SumaCifrelor(numar);
            Console.WriteLine("Suma cifrelor a nr introdus este: " + sumaCifrelor);
        }

        //functie calcul suma cifrelor unui numar
        static int SumaCifrelor(int nr)
        {
            int suma = 0;
            while (nr > 0)
            {
                suma += nr % 10; // suma = suma + x % 10;
                nr /= 10;        // x = x / 10;
            }
            return suma;
        }
    }

}
