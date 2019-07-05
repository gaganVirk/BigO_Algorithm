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
            Console.WriteLine(Sum(2));
        }
        static int Sum(int n)
        {
            if(n <= 0)
            {
                return 0;
            }

            return n + Sum(n - 1);
        }
       
    }
}
