using System;

namespace vectoriLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] vectorIntregi = new int[10];
            //bool[] vectorBool = new bool[4];
            //bool[] vectorB2 = new bool[] { true, false };

            //vectorIntregi[4] = 3;

            Console.WriteLine("Introduceti numarul:");
            int n = int.Parse(Console.ReadLine());
            //int[] vector= ReadVector(n);


            int[] v2 = ReadVector(n);
            InvertArrayMark2(v2);
            ShowVector(v2);
           // ShowVector(InvertArray(ReadVector(n)));

            //int[] v2 = new int[] { 1, 2, 3 };

            //int[] v3 = v2;
            //v2[1] = -10;


            //ShowVector(vector);
        }
        static void InvertArrayMark2(int[] toInvert)
        {
            //int[] inverted = new int[toInvert.Length];

            for (int i = 0; i < toInvert.Length/2; i++)
            {
                int aux = toInvert[i];
                toInvert[i] = toInvert[toInvert.Length - 1 - i];
                toInvert[toInvert.Length - 1 - i] = aux;
            }
  
        }

        static int[] InvertArray(int[] toInvert)
        {
            int[] inverted = new int[toInvert.Length];
                
                for (int i = 0; i < toInvert.Length; i++)
            {
                inverted[toInvert.Length - 1 - i] = toInvert[i];
            }
            return inverted;
        }

        //functie citire vector
        static int[] ReadVector (int n)
        {
            int[] result = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");

            for (int i = 0; i<n; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        //numarul total de elementele vectorului
        static void ShowVector(int[] vectorToSHow)
        {
            Console.WriteLine(" Afisam vectorul: ");

            for (int i = 0; i < vectorToSHow.Length; i++)
            {
                Console.WriteLine(vectorToSHow[i]);
            }
        }
    }
}
