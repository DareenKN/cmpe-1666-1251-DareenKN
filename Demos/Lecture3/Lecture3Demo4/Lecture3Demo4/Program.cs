/* CMPE1666 - Intermediate Programming
 * Lecture 3 Demo 4 - Using LINQ methods on List<T>
 * 
 * Name: Dareen Kinga Njatou
 * 
 * Date: October 3, 2025
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
            List<int> list = new List<int> { 15, 25, 12, 8, 32, 43, 18, 21, 11, 5, 8, 12 };

            // We'll test  a nuber of different methods

            Console.WriteLine($"The minimum value in the list is {list.Min()}");
            Console.WriteLine($"The maximum value in the list is {list.Max()}");
            Console.WriteLine($"The average value in the list is {list.Average()}");
            Console.WriteLine();

            // Removing value 32 from the list
            list.Remove(32);
            Console.WriteLine($"After removing 32 from the list, our list becomes: {string.Join(", ", list)}");
            Console.WriteLine($"The minimum value in the list is {list.Min()}");
            Console.WriteLine();
            list.Reverse();
            Console.WriteLine($"After reversing the list becomes: {string.Join(", ", list)}");
            Console.WriteLine();
            list.RemoveAt(3);
            Console.WriteLine($"After removing the value at index 3, the list becomes: {string.Join(", ", list)}");
            Console.WriteLine();

            // Removing 8 from the list
            list.Remove(8);
            Console.WriteLine($"After removing 8 from the list, the list becomes: {string.Join(", ", list)}");
            Console.WriteLine();

            list.Clear();
            Console.WriteLine($"After clearing the list, the list becomes: {string.Join(", ", list)}");

            Console.ReadKey();
        }
    }
}
