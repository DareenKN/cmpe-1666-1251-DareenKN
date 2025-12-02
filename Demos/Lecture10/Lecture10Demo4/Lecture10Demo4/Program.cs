/* CMPE1666 - Intermediate Progammming
 * Name: Njatou Dareen
 * 
 * Lecture 10 Demo 4
 * 
 * Date: December 2, 2025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture10Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ParameterizedThreadStart(Counter));
            th1.Name = "Start(5)";
            th1.IsBackground = true;
            th1.Start(5);

            // Here we are implicitly using ParameterizedThreadStart. By the context 
            // (i.e given that Counter has the requires parameter type), the system
            // knows that it has to use tye ParameterizedThreadStart delegate
            Thread th2 = new Thread(Counter);
            th2.Name = "Start(8)";
            th2.IsBackground = true;
            th2.Start(8);

            // We place this ReadKey() to prevent the main thread to exit the program
            Console.ReadKey();
        }

        static void Counter(object arg)
        {
            // This statement verifies that our incoming value is of type int
            // If so, perform the casting and stores the resulting value in the
            // variable loopCount
            if (arg is int loopCount)
            {
                for(int i=0; i < loopCount; ++i)
                {
                    Thread.Sleep(10);
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                }
            }
        }
    }
}
