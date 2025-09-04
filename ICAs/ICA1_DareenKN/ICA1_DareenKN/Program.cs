/* CMPE1666 - Intermediate Programming
 * 
 * Name: Dareen Kinga Njatou
 * Description: This program generates an array of random 
 *              integers within a user-defined range and size.
 * 
 * Date: September 3, 2025
 */
using System;

namespace ICA1_DareenKN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display Title
            string title = "ICA 1 - Dareen K. N. - Linear Search";
            Console.CursorLeft = (Console.WindowWidth - title.Length) / 2;
            Console.WriteLine(title);
            Console.Title = title;

            int lower;          // lower limit of the range
            int upper;          // upper limit of the range
            int size;           // size of the array
            int[] array;        // the array of integers
            string searchAgain; // control searching for another value
            int searchValue;    // value to search for
            int occurrences;    // number of occurrences of the search value in the array

            // Get user inputs
            size = GetValue("Input the size of the array to generate (10-100): ", 10, 100);
            GetRange(out lower, out upper);

            // Generate and display the array
            array = GenerateArray(size, lower, upper);
            DisplayArray(array);

            // Search for values in the array
            do
            {
                searchValue = GetValue($"\nEnter Value to be searched ({lower}-{upper}): ", lower, upper);
                occurrences = CountOccurrences(array, searchValue);

                // Display the result
                if (occurrences == 0)
                    Console.WriteLine($"{searchValue} not found in array");
                else
                    Console.WriteLine($"\nNumber of Occurences of {searchValue} is {occurrences}");

                // Ask if the user wants to search again
                do
                {
                    Console.Write("\nDo you want to search for another value? (Y/N, y/n): ");
                    searchAgain = Console.ReadLine();

                    // Validate input for searching again
                    if (searchAgain != "Y" && searchAgain != "y" && searchAgain != "N" && searchAgain != "n")
                        Console.WriteLine("You should respond by: Y/y,N or n. Please input again");
                } while (searchAgain != "Y" && searchAgain != "y" && searchAgain != "N" && searchAgain != "n");


            } while(searchAgain== "Y" || searchAgain == "y");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Get an integer value from the user within a specified range.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static int GetValue(string prompt, int min, int max)
        {
            int value = 0; bool valid = false;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out value);
                if (!valid)
                    Console.WriteLine("The input value is not valid- You have to input another value\n");
                else if (value < min || value > max)
                    Console.WriteLine($"The input is out of range- You have to input in the range {min}-{max}\n");
            }
            while (!valid || value < min || value > max);
            return value;
        }

        /// <summary>
        /// Get a valid range (lower and upper limits) from the user.
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        static void GetRange(out int lower, out int upper)
        {
            Console.WriteLine();
            do
            {
                lower = GetValue("Enter the lower limit of the range of values to generate (0-100): ", 0, 100);
                upper = GetValue("\nEnter the upper limit of the range of values to generate (0-100): ", 0, 100);

                if (lower >= upper)
                    Console.WriteLine("The lower limit must be less than the upper limit- You have to input another range\n");

            } while (lower >= upper);
        }

        /// <summary>
        /// Generate an array of random integers within a specified range.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        static int[] GenerateArray(int size, int lower, int upper)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(lower, upper + 1);
            }
            return array;
        }

        /// <summary>
        /// Display the contents of an integer array.
        /// </summary>
        /// <param name="array"></param>
        static void DisplayArray(int[] array)
        {
            Console.Write("\nThe generated values are: ");
            for (int i = 0; i < array.Length; i++)            
                Console.Write(array[i] + " ");                
            
            Console.WriteLine();            
        }

        /// <summary>
        /// Count the occurrences of a specific value in an integer array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static int CountOccurrences(int[] array, int value)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item == value)
                    count++;
            }
            return count;
        }
    }
}
