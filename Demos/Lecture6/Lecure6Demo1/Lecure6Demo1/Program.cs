/* CMPE 1666 - Intermediate Programming
 * 
 * Lecture 6 -Demo 1- Comparing Iterative and Recursive Executions
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecure6Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            result = SumInts(5);

            Console.WriteLine($"The result is: {result}");

            Console.ReadKey();
        }

        // Iterative method to find sum of all values from 0 to n for any positive integer n
        private static int SumInts (int n)
        {
            int iSum = 0;
            for (int x = n; x >= 0; --x)
                iSum += x;
            return iSum;
        }
    }
}
