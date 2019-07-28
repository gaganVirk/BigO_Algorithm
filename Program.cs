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
            foo(3,4);
        }

        static void foo(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[i] + " " + array[j]);
                }
            }
        }
    }



}
