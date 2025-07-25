﻿using System;

namespace Cronometro
{
  class Program
 {
        static void Main(string[] args)
        {
            Menu();
            static void PreStart(int time)
            {
                Console.Clear();
                Console.WriteLine("Ready...");
                Thread.Sleep(1000);
                Console.WriteLine("Set..");
                Thread.Sleep(1000);
                Console.WriteLine("Go..");
                Thread.Sleep(2500);

                Start(time);

            }

        }
        static void Menu()
        {
             Console.Clear();
             Console.WriteLine("S = Segundos => 10s = 10 segundos");
             Console.WriteLine("M = Minutos => 1m = 1 minuto");
             Console.WriteLine("0 = Sair");
             Console.WriteLine("Quanto tempo deseja contar?");

             string data = Console.ReadLine().ToLower();
             char type = char.Parse(data.Substring(data.Length - 1, 1));
             int time = int.Parse(data.Substring(0, data.Length - 1));
             int multiplier = 1;

             if (type == 'm')
                multiplier = 60;

             if (time == 0)
                System.Environment.Exit(0);

             Start(time * multiplier);           
  
        }
        static void Start(int time)
        {
            int currenTime = 0;

            while (currenTime != time)
            {
                Console.Clear();
                currenTime++;
                Console.WriteLine(currenTime);
                Thread.Sleep(1000);

            }
            Console.Clear();
            Console.WriteLine(" Cronometro Finalizado");
            Thread.Sleep(2500);
            Menu();
        }
 
  }

}


