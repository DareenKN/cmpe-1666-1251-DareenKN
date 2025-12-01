
/**CMPE 1666- Intermediate Programming
 * 
 * Lecture 9- Exercise1
 * 
 * Working with delegates
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Exercise1
{
    internal class Program
    {  //Creating the delegate type
        public delegate int delBinaryOp(int x, int y);
        static void Main(string[] args)
        {
            delBinaryOp _delAdd = new delBinaryOp(Addition);
            delBinaryOp _delMult = new delBinaryOp(Multiplication);
            delBinaryOp _delDiv = new delBinaryOp(Division);

            Console.WriteLine($"_delAdd.Invoke(6,5) gives us: {_delAdd.Invoke(6,5)}");
            Console.WriteLine($"_delMult.Invoke(6,5) gives us: {_delMult.Invoke(6, 5)}");
            Console.WriteLine($"_delDiv.Invoke(19,5) gives us: {_delDiv.Invoke(19, 5)}");
            Console.WriteLine();

            Console.WriteLine("Press Any Key To Exit Program");
            Console.ReadKey();
        }


        static private int Addition(int val1, int val2)
        {
            return val1 + val2;
        }

        static private int Multiplication(int val1, int val2)
        {
            return val1*val2;
        }

        static private int Division(int val1, int val2)
        {
            return val1/val2;
        }

    }
}
