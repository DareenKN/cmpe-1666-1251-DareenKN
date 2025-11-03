using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { };


            int P1;
            int value;
            bool over = false;

            while (!over)
            {
                Console.Write("Input the value you want to search: ");
                // Assume the user is giving valid value
                int.TryParse(Console.ReadLine(), out value);
                //From main, we pass 0 and myList.Count-1 as the low and High indices
                P1 = RBinarySearch(myList, 0, myList.Count - 1, value);
                if (P1 >= 0)
                    Console.WriteLine($"{value} found at position {P1} in list");
                else
                    Console.WriteLine($"{value} not found in list");

                string ans;
                do
                {
                    Console.Write("Do you want to search for another value (Y/N): ");
                    ans = Console.ReadLine().ToUpper();
                } while (ans != "Y" && ans != "N");

                if (ans == "Y")
                    over = true;
            }

            Console.ReadKey();

        }

        // The method RBinarySearch searches a list of int for a value val between
        // the indices low and high. It finds the value at the mid index
        // If the value matches the search value, the mid index is returnes
        // Otherwise it recursively searches the lower half ot the upper half
        // based on wether the search value is lower than the one at middele index
        // or higher than it

        static private int RBinarySearch(List<int> L, int low, int high, int val)
        {
            // The algorithm stops and returns -1 if low becomes > high
            if(high >= low)
            {
                // Calculate the middle index
                int mid = (low + high) / 2;
                // Verifiy if the value at the middle index et what we are searching for
                // If so, return the middle index
                if (L[mid] == val)
                    return mid;
                else if (val < L[mid])
                    return RBinarySearch(L, low, mid - 1, val);
                else RBinarySearch(L, mid + 1, high, val); ;

            }
            return - 1;// If we arrive here, it means low>high. Value not found
        }
    }
}
