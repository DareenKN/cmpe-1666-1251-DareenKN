/* CMPE 1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: Lecture 9 Demo 1 - Introduction to Delegates
 *
 * Date: October 17 2025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Demo1
{
    internal class Program
    {
        // Creating a delegate type
        public delegate void DelSingleString(string str);

        static void Main(string[] args)
        {
            // We create an object of class DelSingleString and assign the 
            // method displayString to it
            DelSingleString firstObject = new DelSingleString(DisplayString);

            // We need to invoke DisplaySString(), we can do it through the delegate object
            firstObject.Invoke("Hello - How are you?");

            DelSingleString secondObject = new DelSingleString(DisplayUpper);
            secondObject.Invoke("Hello - How are you?");


            Console.ReadKey();
        }

        private static void DisplayString(string s)
        {
            Console.WriteLine(s);
        }
        private static void DisplayUpper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }
}
