using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex2
            Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati - o si afisati-i rezultatul*/

            Console.WriteLine("Introduceti numarul:");
            int numar = int.Parse(Console.ReadLine());

            if (IsPrim(numar))
            {
                Console.WriteLine("Numarul este prim");
            }
            else
            { Console.WriteLine("Numarul nu este prim"); }
        }

        static bool IsPrim(int x)
        {
            if (x == 0 || x == 1)
            { return false; }
            else
            {
                for (int i = 2; i < x / 2; i++) // cel mai mare numar cu care un numar poate fi divizibil ii jumatatea lui 
                {
                    if (x % i == 0)
                        return false;
                }
                return true;

            }
        }
        }
    }

