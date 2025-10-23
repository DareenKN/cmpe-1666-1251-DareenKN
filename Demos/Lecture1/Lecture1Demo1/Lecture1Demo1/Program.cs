/*CMPE 1666- Intermediate Programming
 * Lecture1- Demo1
 * 
 * Using combined cases
 * 
 * Author: Oveeyen Moonian
 * Date: September 02, 2025
 * 
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

            Console.Write("Give a month number (1 for January... 12 for December");
            success=int.TryParse(Console.ReadLine(), out monthNumber);

            if (success)
            {   
                switch (monthNumber)
                {
                    case 12:
                    case 1:
                    case 2: Console.WriteLine("The season is winter");
                            break;
                    case 3:
                    case 4:
                    case 5: Console.WriteLine("The season is spring");
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
                    default: Console.WriteLine("Wrong Month Number Given, must be 1..12");
                        break;


                }


            }
            else
            {
                Console.WriteLine("The input value was invalid");
            }



                Console.WriteLine("Press Any Key To Exit Program");
            Console.ReadKey();


        }
    }
}
