using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StringCompareDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result of Striing.Compare(\"Hello\", \"Apple\"): {string.Compare("Hello", "Apple")}");
            Console.WriteLine($"Result of Striing.Compare(\"Apple\", \"Hello\"): {string.Compare("Apple", "Hello")}");
            Console.WriteLine($"Result of Striing.Compare(\"apple\", \"apple\"): {string.Compare("apple", "apple")}");
            Console.WriteLine($"Result of Striing.Compare(\"apple\", \"Apple\"): {string.Compare("apple", "Apple")}");

            Console.ReadKey();
        }


        // It sorts a list of strings in ascending alphabetical order
        private void InsertionSort(List<string> strList)
        {
            int n = strList.Count;

            // We use p for the pass number and we
            // start with 1 as the first pass number
            for (int p = 1; p < n; p++)
            {
                string temp = strList[p];   // We store the value at position P in a 
                                            // temporary variable "temp"
                int j = p - 1;  // j will be our iteration variable starting wih p
                                // and moving backwards

                // We keep looking at the previous position as long

                while((j>=0) && (strList[j].CompareTo(temp) > 0))
                {
                    // As long as we obtain values bigger than temp, we shift them to the right
                    strList[j + 1] = strList[j];
                    j = j - 1; // After shifing the value, we again move back one position
                }

                // When we come out of the loop, we have already moved one step to far.
                // So we move one postion to the right and store our value there
                strList[j + 1] = temp;
            }
            
        }

        private void InsertionSort(List<string> strList)
        {
            int n = strList.Count;

            // We use p for the pass number and we
            // start with 1 as the first pass number
            for (int p = 1; p < n; p++)
            {
                Employee temp = strList[p];   // We store the value at position P in a 
                                              // temporary variable "temp"
                int j = p - 1;  // j will be our iteration variable starting wih p
                                // and moving backwards

                // We keep looking at the previous position as long

                while ((j >= 0) && (strList[j]._lastName.CompareTo(temp._lastName) > 0))
                {
                    // As long as we obtain values bigger than temp, we shift them to the right
                    strList[j + 1] = strList[j];
                    j = j - 1; // After shifing the value, we again move back one position
                }

                // When we come out of the loop, we have already moved one step to far.
                // So we move one postion to the right and store our value there
                strList[j + 1] = temp;
            }

        }
    }
}
