/* CMPE 1666- Intermediate programming
 * 
 * Lecture9-Demo1- Introduction To delegates
 * 
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
        //Creating a delegate type
        public delegate void delSingleString(string str);
        static void Main(string[] args)
        {
            //We create an object of class delSingleString and assign the 
            //method displayString to it.
            delSingleString firstObject = new delSingleString(displayString);

            //When we need to invoke displayString(), we can do it through the delegate object
            firstObject.Invoke("Hello- How are you?");
            
            delSingleString secondObject=new delSingleString(displayUpper);
            secondObject.Invoke("Hello- How are you?");


        }

        static private void displayString(string s)
        {
            Console.WriteLine(s);
        }
        static private void displayUpper(string s1)
        {
            Console.WriteLine(s1.ToUpper());
        }

    }
}
