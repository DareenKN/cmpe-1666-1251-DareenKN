/*CMPE 1666- Intermediate Programming
 * 
 * Lecture 3- Demo - Working with List methods
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {15,25, 12, 8, 32, 43, 18, 21, 11, 5, 8,12, 20, 8, 25, 33, 8 };

            //We'll test a number of different methods

            Console.WriteLine($"Initial List is: {string.Join(", ", list)}");
            Console.WriteLine();
            Console.WriteLine($"The minimum value in the List is: {list.Min()}");
            Console.WriteLine($"The maximum value in the List is: {list.Max()}");
            Console.WriteLine($"The average value in the List is: {list.Average()}");
            Console.WriteLine();
            //Removing vaue 32 from the List
            list.Remove(32);
            Console.WriteLine($"After removing 32 from the list, our list becomes: {string.Join(", ",list)}");
            Console.WriteLine();
            list.Reverse();
            Console.WriteLine($"After Reversing, the list becomes: {string.Join(", ",list)}");
            Console.WriteLine();
            list.RemoveAt(3);
            Console.WriteLine($"After Removing element at position 3, the list becomes: {string.Join(", ", list)}");
            Console.WriteLine();
            //Removing 8 from the list
            list.Remove(8);
            Console.WriteLine($"After removing 8 from the list, our list becomes: {string.Join(", ", list)}");
            Console.WriteLine();

            list.Clear();
            Console.WriteLine($"After executing Clear, our list becomes: {string.Join(", ", list)}");
            Console.WriteLine();


        }
    }
}
