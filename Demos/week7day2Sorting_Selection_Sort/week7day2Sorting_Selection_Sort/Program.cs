using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7day2Sorting_Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array to stores numbers
            int[] numbers = { 56, 7, 4, 9, 21, 37, 17, 91 };

            // Print array before sorting
            Console.Write("List before Sorting: ");
            PrintValues(numbers);

            // Sort the list using selection sort method
            SelectionSort(numbers);

            // Print array after sorting
            Console.Write("\nList before Sorting: ");
            PrintValues(numbers);

            Console.ReadKey();
        }

        public static void PrintValues(int[] list)
        {
            foreach (int item in list)
            {
                Console.Write($"{item}, ");
            }
        }

        /// <summary>
        /// Method to perform selection sort
        /// </summary>
        /// <param name="arr">Array to sort</param>
        /// <return>Nothimg</return>
        public static void SelectionSort(int[] arr)
        {
            int numberOfElements = arr.Length;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minElementIndex = i;

                // Finding the smallest element's index from rest of the list
                for (int j = i +1; j<numberOfElements; ++j)
                {
                    if (arr[j] < arr[minElementIndex])
                    {
                        minElementIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = arr[minElementIndex];
                arr[minElementIndex] = arr[i];
                arr[i] = temp;
            }

        }
    }
}
