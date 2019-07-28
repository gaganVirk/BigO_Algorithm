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
            foo(3,4,5,6);
        }

        static void foo(params int[] array)
        {
            int sum = 0;
            int product = 1;

            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            for(int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine(sum + " " + product);
        }
    }



}
