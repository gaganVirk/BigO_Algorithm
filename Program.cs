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
            Console.WriteLine(pairSumSequence(3));
        }
        static int pairSumSequence(int n)
        {
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += pairSum(i, i + 1);
            }
            return sum;
        }

        public static int pairSum(int a, int b)
        {
            return a + b;
        }
       
    }
}
