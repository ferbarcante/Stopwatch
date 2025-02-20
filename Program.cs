using System;
using System.Threading;

namespace Stopwatch
{
    class Program 
    {
        static void Main(string[] args)
        {
            StartStopwatch();
        }

        static void StartStopwatch()
        {
            Console.Clear();
            Console.WriteLine("Stopwatch started!");

            int time = 10;
            
            while(time > 0)
            {
                Console.Clear();
                time--;

                Console.WriteLine($"{time} seconds remaining...");
                Thread.Sleep(1000);
            }
        }   
    }
}