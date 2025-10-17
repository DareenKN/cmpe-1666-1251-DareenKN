using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Deemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Random rand = new Random();

            // Generate 1 random interger values and add to the list
            for (int count = 0; count < 15; count++)
            {
                // We limit the random values to 1..99
                intList.Add(rand.Next(1, 100));
            }

            Console.WriteLine($"Initial List: {string.Join(", ", intList)}");
            Console.WriteLine();

            SelectionSort(intList);
            Console.WriteLine($"After Sorting List List: {string.Join(", ", intList)}");
            Console.WriteLine();

            Console.WriteLine("Press Any Key To Exit Program");
            Console.ReadKey();

        }

        private static void SelectionSort(List<int> list)
        {
            // n is the number of element in the list
            int n = list.Count;

            // We have n-1 passes - we number them from 0 to n-2
            for (int pass = 0; pass < n - 1; pass++)
            {
                // We firt set max_posn to 0
                int max_posn = 0;   // This variable wil keep track
                                    // of the possition of the maximum value
                int last_posn = n - 1 - pass;   // This is the last position
                                                // of the still unsorted list

                // In each pass we iterate over the still unsorted pa
                // and fins the maximum value, which we send to the la
                // unsorted position
                for (int j = 0; j <= last_posn; j++)
                {
                    if (list[j] > list[max_posn])
                    {
                        max_posn = j;
                    }
                }

                Swap(list, max_posn, last_posn);

            }
        }

        private static void Swap(List<int> myList, int posn1, int posn2)
        {
            int temp = myList[posn1];
            myList[posn1] = myList[posn2];
            myList[posn2] = temp;
        }
    }   
   
}
