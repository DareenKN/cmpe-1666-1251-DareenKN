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
            int[] array = new int[] {1, 2, 3, 4, 5};

            Console.WriteLine($"The size of the array is: {array.Length}");

            // Here i is the index of the array element
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"array[{i}]= {array[i]}");

            // Iterating through the array using the foreach loop
            // In this case x refers to the actual array element, not the index
            foreach (int x in array)
                Console.Write(x);

            // Working with an array of strings
            string[] Months = { };

            //Displaying the months numbers and names
            for (int month = 1; month <= Months.Length; month++)
                Console.WriteLine($"{month}. {Months[month - 1]}");

            // Allow the user to input a value in the range 1..12
            int monthNumber; 
            bool success;
            Console.Write("Give a month number (1 for January... 1 for December): ");
            success = int.TryParse(Console.ReadLine(), out monthNumber);

            if (success)
            {                
                Console.Write(($"Month is {Months[monthNumber - 1]}... "));

                switch (monthNumber)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("The season is Winter");
                        break;

                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("The season is Spring");
                        break;

                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("The season is Summer");
                        break;

                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("The season is Fall");
                        break;

                    default:
                        Console.WriteLine("Wrong Month Number Given, mut be 1... 12");
                        break;
                }


            }
            else
            {
                Console.WriteLine("The input value was not valid");
            }

            Console.WriteLine("Press Any Key to Exit Program");
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
