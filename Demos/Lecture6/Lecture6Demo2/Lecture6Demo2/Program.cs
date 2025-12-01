/*CMPE 1666- Intermediate Programming
 * 
 * Lecture6-Demo2- Types of Recursion
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();


            Console.Write("Result of PreOrder Recursion: ");
            PreOrder(word, 0);
            Console.WriteLine();

            Console.Write("Result of PostOrder Recursion: ");
            PostOrder(word, 0);
            Console.WriteLine();

            Console.Write("Result of InOrder Recursion: ");
            InOrder(word, 0);
            Console.WriteLine();

            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            List<int> Factors = new List<int>();
            FactorFinder(number, 1, Factors);
            Console.Write($"Factors:{string.Join(", ", Factors)}");

            Console.WriteLine();
            Console.WriteLine();


            //foreach (int n in Factors)
            //    Console.Write($"{n}, ");

            // Factorial 5!= 5 x 4 x 3 x 2 x 1 = 120 

            // Console.WriteLine($"5!=  {Factorial(5)} ");

            Console.WriteLine("Press Any key to Exit program");
            Console.ReadKey();

        }

        public static void PreOrder(string sString, int iPosition)
        {
            if (iPosition != sString.Length)
            {
                Console.Write(sString[iPosition]);
                PreOrder(sString, iPosition + 1);
            }

        }

        public static void PostOrder(string sString, int iPosition)
        {
            if (iPosition != sString.Length)
            {
                PostOrder(sString, iPosition + 1);
                Console.Write(sString[iPosition]);
               
            }

        }

        public static void InOrder(string sString, int iPosition)
        {
            if (iPosition != sString.Length)
            {
                Console.Write(sString[iPosition]);
                InOrder(sString, iPosition + 1);
                Console.Write(sString[iPosition]);

            }

        }

        

        private static int Factorial(int n)
        {
            // Factorial 5!= 5 x 4 x 3 x 2 x 1 = 120 
            Console.WriteLine($"5!=  {Factorial(5)} ");

            if (n == 0)  // Base Condition because 0! = 1
                return 1;
            else
                return n * Factorial(n - 1);  // n * (n-1)!
        }

        public static void FactorFinder(int number, int i, List<int> Factors)
        {
            // Factors finder number = number % i == 0
            //In short no remainder when it is been divided by the number
            if (i > number)
                return;

            if (number % i == 0)
                Factors.Add(i);

            FactorFinder(number, i + 1, Factors);
                
        }

    }
}
