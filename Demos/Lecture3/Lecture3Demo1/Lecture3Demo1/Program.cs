/*CMPE 1666- Intermediate programming
 * 
 * Lecture3 Demo1- working with Lists
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myData = new List<string>();
            myData.Add("Monkey");
            myData.Add("Elephant");

            //We can access elements from the List by using the List name and Index
            Console.WriteLine($"myData[0]: {myData[0]}");
            Console.WriteLine($"myData[1]: {myData[1]}");
            Console.WriteLine();

            //Insert an element at position  0
            myData.Insert(0, "Goat");

            Console.WriteLine("After Inserting \"Goat\" at position 0, we obtain");

            Console.WriteLine($"myData[0]: {myData[0]}");
            Console.WriteLine($"myData[1]: {myData[1]}");
            Console.WriteLine($"myData[2]: {myData[2]}");
            Console.WriteLine();

            //Iterating over the List using a foreach loop
            Console.WriteLine("Iterating over the List, with a foreach loop, we obtain: ");
            foreach(string S in myData)
            {
                Console.WriteLine(S);
            }
            Console.WriteLine();

            //Iterating over the List using a foreach loop
            Console.WriteLine("Using a for loop,we can also display the index of each element: ");
            for (int count=0; count<myData.Count; count++ )
            {
                Console.WriteLine($"myData[{count}]: {myData[count]}");
            }
            Console.WriteLine();

            Console.WriteLine("Press Any key To Exit program");
            Console.ReadKey();

        }
    }
}
