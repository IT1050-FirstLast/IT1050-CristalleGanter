﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristalleGanterLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine(n);

            while (n < 9)
            { Console.WriteLine(n + 2); n = n + 2; }

            int i = 30;
            for (i = 30; i <= 45; i++)
            { Console.WriteLine(i); }

            int t = 17;
            if (t <= 11)
            { Console.WriteLine("Good Morning"); }

            if (t >= 12 && t <= 16)
            { Console.WriteLine("Good Afternoon"); }

            if (t > 16)
            { Console.WriteLine("Good Evening"); }

            // There was no part where anything was added to the initial number so it just kept putting out 10.
            int x = 10;
            while (x < 21)
            {
                Console.WriteLine(x++);
            }


            for (int c = 0; c < 101; c++)
            {
                Console.WriteLine(c);
                Console.WriteLine("********");
            }

            int p = 1;
            for (p = 1; p <= 1; p++)
            {
                Console.Write("*");
                Console.WriteLine();
                for (int r = 1; r <=1; r++)
                {
                    Console.Write("**");
                    Console.WriteLine();

                }

                for (int q = 1; q <= 1; q++)
                {
                    Console.Write("***");
                    Console.WriteLine();
                }

                for (int e = 1; e <= 1; e++)
                {
                    Console.Write("****");
                    Console.WriteLine();
                }
                for (int w = 1; w <= 1; w++)
                {
                    Console.Write("*****");
                    Console.WriteLine();
                }
                for (int y = 1; y <= 1; y++)
                {
                    Console.Write("******");
                    Console.WriteLine();
                }
                for (int u = 1; u <= 1; u++)
                {
                    Console.Write("*******");
                    Console.WriteLine();
                }

                for (int a = 1; a <= 1; a++)
                {
                    Console.Write("********");
                    Console.WriteLine();
                }
                for (int z = 1; z <= 1; z++)
                {
                    Console.Write("*********");
                    Console.WriteLine();
                }
                for (int c = 1; c <= 1; c++)
                {
                    Console.Write("**********");
                    Console.WriteLine();
                }
            }


        }

        } 
}
