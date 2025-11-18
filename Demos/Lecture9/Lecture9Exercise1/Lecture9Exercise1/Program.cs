using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Exercise1
{
    internal class Program
    {
        // Creating a delegate type
        public delegate int delBinaryOp(int val1, int val2);
        static void Main(string[] args)
        {
            // Creating appropriate delegate objects
            delBinaryOp Obj1 = new delBinaryOp(Addition);
            delBinaryOp Obj2 = new delBinaryOp(Multiplication);
            delBinaryOp Obj3 = new delBinaryOp(Division);

            // Using them
            Console.WriteLine($"{Obj1.Invoke(2, 6)}");
            Console.WriteLine($"{Obj2.Invoke(6, 7)}");
            Console.WriteLine($"{Obj3.Invoke(32, 4)}");

            Console.ReadKey();

        }

        // 3 Methods with 2 int parameter and return an int result
        static int Addition(int val1, int vall2)
        {
            return val1 + vall2;
        }
        static int Multiplication(int val1, int val2)
        {
            return val1 * val2;
        }
        static int Division(int val1, int val2)
        {
            return val1 / val2;
        }
    }
}
