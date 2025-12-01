/**
 * CMPE 1666- Intermediate Programming
 * 
 * Lecture6-Demo1- Comparing Iterative and Recursive Executions
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            // result = SumInts(5);

            //  Console.WriteLine($"The result is: {result}");

            result = RSum(5);

            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("Press Any key To exit program");
            Console.ReadKey();

        }

        //Interative method to find the Sum of all values from 0 to n for any positive integer n
        private static int SumInts(int n)
        {
            int iSum = 0;
            for (int x = n; x >= 0; --x)
                iSum += x;

            return iSum;
        }

        //Recursive defintion for the above function
        private static int  RSum(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + RSum(n - 1);
        }
    }
}
