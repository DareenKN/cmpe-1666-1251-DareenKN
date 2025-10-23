/*CMPE 1666- Intermediate Programming
 * 
 * Lecture1- Demo3
 * 
 * Illustrating the difference between value and Reference Type
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = x;

            //compating simple variables
            Console.WriteLine($"Initial values of x: {x} and y:{y} ");

            x = 10;

            Console.WriteLine($"After modification, value of x: {x} and y:{y} ");


            //Comparing arrays
            int[] a = new int[1];
            a[0] = 17;
            int[] b;

            b = a;

            Console.WriteLine($"Initial Values a[0]: {a[0]}, b[0]: {b[0]}");
            a[0] = 25;
            Console.WriteLine($"After modification, Value a[0]: {a[0]}, b[0]: {b[0]}");

            Console.WriteLine("Press Any Key to exit");
            Console.ReadKey();
        }
    }
}
