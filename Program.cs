using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7 };
            printUnorderedPairs(a,b);
        }

        static void printUnorderedPairs(int[] arrayA, params int[] arrayB)
        {
            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] < arrayB[j])
                    {
                        Console.WriteLine(arrayA[i] + " " + arrayB[j]);
                    }
                }
            }
            Console.ReadLine();
        }
    }



}
