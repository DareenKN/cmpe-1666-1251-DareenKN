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

            Console.Write("Result of PreOrder Recursion: ");
            PreOrder("Hello", 0);
            Console.WriteLine();

            Console.Write("Result of PostOrder Recursion: ");
            PostOrder("Hello", 0);
            Console.WriteLine();

            Console.Write("Result of InOrder Recursion: ");
            InOrder("Hello", 0);
            Console.WriteLine();


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


    }
}
