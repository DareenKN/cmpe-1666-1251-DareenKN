using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> intList = new List<int>();
            Random rand = new Random();

            //Generate 15 random integer values and add to the list
            for (int count=0; count<15; count++)
            {
                //We limit the random values to 1..99
                intList.Add(rand.Next(1, 100));
            }

            Console.WriteLine($"Initial List: {string.Join(", ", intList)}");
            Console.WriteLine();
            SelectionSort(intList);
            Console.WriteLine($"After sorting List is: {string.Join(", ", intList)}");

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Exit Program");
            Console.ReadKey();

        }


       /// <summary>
       /// This method sorts a List of intetgers in Adscending order
       /// using the Selection-Sort Technique.
       /// We proceed by finding the highest value in each pass
       /// and placing the the last position of the still unsorted part
       /// of the List
       /// </summary>
       /// <param name="list">List of Integers to be sorted</param>
        private static  void SelectionSort(List<int> list)
        {
            //n is number of elements in the list
            int n = list.Count;

            //We have n-1 passes - we number them from 0 to n-2
            for (int pass=0; pass<n-1; pass++)
            {
                //we first set max_posn to 0
                int max_posn = 0; // this variable will keep track
                                  // of the position of the maximum value at any time
                int last_posn = n - 1 - pass; //this is the last position
                                             //of the still unsorted part of the list
               
                //In each pass we iterate over the still unsorted part
                //and fins the maximum value, which we send to the last 
                //unsorted position
                for (int j=0; j <= last_posn; j++)
                {
                    if (list[j] > list[max_posn])
                        max_posn = j;
                }

                //At the end of the pass, we swap list[max-posn]
                //and list[last-posn]

                Swap(list, max_posn, last_posn);

            }
        }

        /// <summary>
        /// This method performs swapping between 2 index positions
        /// in a List of integers
        /// </summary>
        /// <param name="myList">list for which swapping is required</param>
        /// <param name="posn1">1st index to swap</param>
        /// <param name="posn2">2nd index to swap</param>
        private static void Swap(List<int> myList, int posn1, int posn2)
        {
            int temp = myList[posn1];
            myList[posn1] = myList[posn2];
            myList[posn2] = temp;
        }
    }
}
