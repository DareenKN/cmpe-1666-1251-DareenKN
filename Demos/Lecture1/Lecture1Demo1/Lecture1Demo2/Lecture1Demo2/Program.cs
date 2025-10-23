/*CMPE 1666- Intermediate Programming
 * Lecture 1- Demo2
 * 
 * Working with Arrays
 * Author: Oveeyen Moonian
 * Date: September 02, 2025
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"The size of the array is: {array.Length}");

            //Here i is the index of the array element
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]= {array[i]}");
                
            }

            //Iterating through the array using a foreach loop
            //In this case x refers to the actual array element, not the index
            foreach (int x in array)
            {
                Console.WriteLine(x);
                
            }


            //Working with an array of strings
            string[] Months = {"January","February", "March", "April", "May",
                               "June", "July", "August", "September", "October", "November",
                               "December"};

            //Displaying the months num ers and names
            for (int month=1; month<=Months.Length; month++)
            {
                Console.WriteLine($"{month}. {Months[month - 1]}");
            }
            //Allow the user to input a value in the range of 1..12
            bool success;
            Console.Write("Input a month number (1 for January..12 for December) ");
            int monthNumber;
            success = int.TryParse(Console.ReadLine(),out monthNumber);

            if (success)
            {
               
                Console.Write($"Month is {Months[monthNumber - 1]}... Season is ");
                switch (monthNumber)
                {
                    case 12:
                    case 1:
                    case 2: Console.WriteLine("Winter");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Spring");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Summer");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Fall");
                        break;
                    default:
                        Console.WriteLine("not defined, since the value is out of range");
                        break;

                }
            }


            Console.WriteLine("Press Any Key To Exit Program");
            Console.ReadKey();
        }
    }
}
