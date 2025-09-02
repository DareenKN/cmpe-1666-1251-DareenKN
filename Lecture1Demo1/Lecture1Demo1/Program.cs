/* CMPE 1666- Intermidiate Programming
 * Lecture1- Demo1
 * 
 * Using multiple combined cases
 * 
 * Authore: Dareen Kinga Njatou
 * Date: September 02, 2025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthNumber;
            bool success;

            Console.Write("Give a month number (1 for January... 1 for December): ");
            success = int.TryParse(Console.ReadLine(), out monthNumber);

            if (success)
            {
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

        }
    }
}
