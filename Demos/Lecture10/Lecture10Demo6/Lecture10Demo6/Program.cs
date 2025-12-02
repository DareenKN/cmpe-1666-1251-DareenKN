/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga NJatou
 * 
 * Lecture 10 Demo 6 - Passing more than one value as 
 *          PARAMETER TO A THREAD
 * 
 * Date: December 2, 2025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture10Demo6
{
    internal class Program
    {
        private struct PrimeData
        {
            public int Min;
            public int Max;
        }

        static void Main(string[] args)
        {
            // Creation of a PrimeData Struct using the struct initializer
            PrimeData data = new PrimeData { Min = 1, Max = 100 };

            // Alternatively we could also have used the long form
            // Thread thPrime = new Thread(new ParameterizedThreadStart(FindPrime));
            Thread thPrime = new Thread(FindPrime);
            thPrime.IsBackground = true;
            thPrime.Start(data);
            Console.ReadKey();
        }

        static void FindPrime (object objData)
        {
            // Type checking and casting in one step
            if(objData is PrimeData Prime)
            {
                bool bIsPrime = true;

                for (int iNumber = Prime.Min; iNumber <= Prime.Max; ++iNumber)
                {
                    bIsPrime = true;

                    // For each value, we are investigating, we verify if it is divisible
                    // by any value from 2 up to but not including the number itself
                    for (int iTry = 2; iTry <= iNumber - 1; ++iTry)
                    {
                        // If it is divisible by any value, it is not prime
                        if (iNumber % iTry == 0)
                            bIsPrime = false;
                    }

                    // If we get out of the loop and bPrime is still true,
                    // it means our iNumber is prime, then we display it.
                    if (bIsPrime)
                        Console.WriteLine(iNumber);
                }
            }
        }
    }
}
