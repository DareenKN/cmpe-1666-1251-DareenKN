using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Day2QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 21, 12, 18, 30, 8, 23, 65, 41, 32 };

            QuickSort(numbers, 0, numbers.Length - 1);

            foreach (int item in numbers)
                Console.WriteLine(item);

            Console.ReadKey();

        }

        // The QuickSort Implementation
        private static void QuickSort(int[] arr, int low, int high)
        {
            // We don't say low <'=' high, because low == high,
            // means we are left with just one element
            if (low < high)
            {
                // Partition index at which we can divide the list
                int partitionIndex = Partition(arr, low, high);

                // Recursive call for smaller elements
                QuickSort(arr, low, partitionIndex - 1);
                // Recursive call for greater or equals elements
                QuickSort(arr, partitionIndex + 1, high);
            }
        }

        // Partition function will return the partition index
        // Which is basically the final index of the pivot 
        // element in the list passed
        private static int Partition(int[] arr, int low, int high)
        {
            // Choose the pivot
            int pivot = arr[high]; // last element

            // Set all the pointers
            int i = low - 1;

            // Iterate the list and move all small elements to the left side
            // Elements from low to i are smaaller after every iterations
            for (int j = low; j<high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    // swap element i with j
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Move pivot after smaller elements and return its position
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;   // Index position of pivot element
        }
    }
}
