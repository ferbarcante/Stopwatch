﻿using System;
using System.Threading;

namespace Stopwatch
{
    class Program 
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm')
              multiplier = 60;

            if(time == 0)
              System.Environment.Exit(0);

            StartStopwatch(time * multiplier);
        }

        static void StartStopwatch(int time)
        {
            Console.Clear();
            Console.WriteLine("Stopwatch started!");
            
            while(time > 0)
            {
                Console.Clear();
                time--;

                Console.WriteLine($"{time} seconds remaining...");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch stopped!");
            Thread.Sleep(2500);
            Menu();
        }   
    }
}