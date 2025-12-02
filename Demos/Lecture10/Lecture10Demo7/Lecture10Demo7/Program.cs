/* Cmpe1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Lecture 10 Demo 7 
 * 
 * Date: December 2, 2025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture10Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread T1 = new Thread(ThreadTest);

            // Verify the state of T1 at the begining
            Console.WriteLine($"The state of T1 is: {T1.ThreadState.ToString()}");
            T1.IsBackground = true;

            // This sleep is to allow the system time to display the state of thread 1 before it starts to run
            Thread.Sleep(5000);

            T1.Start();

            // We make the main thread sleep for another 2 seconds to allow T1 to run
            Thread.Sleep(2000);

            // At the end of the 2 sec, we verufy the state of T1 again
            Console.WriteLine($"The state of T1 is: {T1.ThreadState.ToString()}");

            if (T1.ThreadState == ThreadState.Stopped)
                Console.WriteLine("Thread T1 has stopped");
        }

        static private void ThreadTest()
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"i = {i}");
                Thread.Sleep(50);
            }
        }
    }
}
