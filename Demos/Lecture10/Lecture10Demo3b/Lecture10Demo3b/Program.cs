using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture10Demo3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread NewThread = new Thread(ThreadMethod);
            NewThread.Start();

            Thread.Sleep(1000);
            Console.WriteLine("Main thread Ending");
            System.Environment.Exit(0);

            //Console.ReadKey();
        }

        static void ThreadMethod() 
        {
            for (int i = 1; i <= 5; ++i) 
            {
                Thread.Sleep(500);
                Console.WriteLine($"New Thread Count = {i}");
            }
        }
    }
}
