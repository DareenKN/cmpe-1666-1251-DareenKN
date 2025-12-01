/*CMPE 1666- Intermediate Programming
 * 
 * Lecture9- Exercise3 - Using Short Form of delegates + Assigning Anonymous functions to delegates
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Exercise3
{
    internal class Program
    {
        public delegate int delBinaryOp(int x, int y);
        static void Main(string[] args)
        {
            delBinaryOp delObj1=null,delObj2=null;

            //We are here using the shortform of assigning a method reference
            //to a delegate for delObj1 and using the long form for delObj2
            delObj1 = Addition;
            delObj2 = new delBinaryOp(Addition);

            //Using the long form of invocation for delObj1 and the short form for delObj2
            Console.WriteLine($"The result of delObj1.Invoke(5,6) is: {delObj1.Invoke(5,6)}");
            Console.WriteLine($"The result of delObj2(5,6) is: {delObj1(5, 6)}");


            //Creating a delegate object for an annonymous method
            delBinaryOp delObj3 = delegate (int x, int y) { return x * y; };

            Console.WriteLine($"The result of delObj3(5,8) is: {delObj3(5, 8)}");


            Console.WriteLine("Press Any key To exit program");
            Console.ReadKey();

        }

        static private int Addition(int val1, int val2)
        {
            return val1 + val2;
        }
    }
}
