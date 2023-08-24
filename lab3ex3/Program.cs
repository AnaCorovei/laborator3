using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex3
            Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul*/

            Console.WriteLine("Introduceti numarul:");
            int numar = int.Parse(Console.ReadLine());

            if (EStePatratPerfect(numar))
            {
                Console.WriteLine("Numarul este patrat perfect");

            }
            else
            {
                Console.WriteLine("Numarul nu este patrat perfect");
            }

            static bool EStePatratPerfect(int x)
            {
                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if ( i * i == x )
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
