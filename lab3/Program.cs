using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             • Exercitiu:
             • Scrieti un program care citind de la tastatura un numar intreg n, si un 
             numar intreg k, va afisa aranjamente de n luate cate k si combinarile de n luate cate K
             */
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti k:");
            int k = int.Parse(Console.ReadLine());
            int arr = GetArranjaments(n, k);

            Console.WriteLine("Introduceti l:");
            int l = int.Parse(Console.ReadLine());

            int max = Math.Max(Math.Max(n, k),l);



            int nFact = GetFactorial(n);
            int kFact = GetFactorial(k);
            int nMinusKFact = GetFactorial(n - k);

            int aNK = nFact / nMinusKFact;
            Console.WriteLine(" Aranjamente " + aNK);

            int cNK = nFact / (nMinusKFact * kFact);
            Console.WriteLine(" Combinari " + cNK);

            int dif64 = Minus(6, 3);
        }
        //aranjamente n luate cate k
        static int GetArranjaments(int n, int k)
        {
            return GetFactorial(n) / GetFactorial(n - k);
        }

        // calculeaza diferenta a 2-a nr
        static int Minus(int x, int y)
        {
            return x - y;
        }

        static void AfiseazaDiferenta(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static int GetFactorial(int n)
        {
            int factorial = 1;
            for (var i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void PrintNumbeerSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("+");
                return;
            } 
            if (number< 0)
            {
                Console.WriteLine("-");
                return;
            } 
                Console.WriteLine(0);
            }
        }
}
