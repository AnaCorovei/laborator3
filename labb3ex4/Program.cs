using System;

namespace labb3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex 4
            Se citeste de la tastatura un vector continand n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
            • Cel mai mare numar din vector
            • Cel mai mic numar din vector
            • Numerele divizibile cu 3
                   Dificultate ridicata
                • Numerele prime din vector
                Apelati functiile si afisati-le rezultatele
            */
            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i< n; i ++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            AfisareVector(v);

            Console.WriteLine("Cel mai mare numar din vector este :" + CelMaiMareNumarDinVector(v));
            Console.WriteLine("Cel mai mic numar din vector este :" + CelMaiMicNumarDinVector(v));

            AfisareVector(DivizibileCuTrei(v));

            Console.WriteLine("Numerele prime din vector sunt:");

            IsPrim(v);
        }

        static void AfisareVector(int[]v)
        {
            Console.WriteLine(" Afisam vectorul: ");

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }

        //cautam si returnam cel mai mare numar din vector
         static int CelMaiMareNumarDinVector(int[] v)
        {
            int max = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > max)
                max = v[i];
            }
            return max;
        }

        //cautam si returnam cel mai mic numar din vector
        static int CelMaiMicNumarDinVector(int[] v)
        {
            int min = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < min)
                    min = v[i];
            }
            return min;
        }

        // functie - vector care are numere divizibile cu 3

        static int[] DivizibileCuTrei(int[] v)
        {
            int contor = 0;
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] % 3 == 0)
                {
                    contor++;
                }
            }
            int[] divCuTrei = new int[contor];
            int j = 0;
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] % 3 == 0)
                {
                    divCuTrei[j] = v[i];
                    j++;
                }
            }
            return divCuTrei;


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
}
