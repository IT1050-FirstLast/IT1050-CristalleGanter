﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab003_CristalleGanter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Numbers Here");
            int a;
            int b;
            int result;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            result = a + b;
            Console.WriteLine("The Solution is " + result);

            int x = 3;
            int y = 2;
            int z = 8;
            int result2;
            result2 = (x + y) * (z + 10);
            Console.WriteLine("The Solution to (x+y)*(z+10) is " + result2);

            Console.WriteLine("Hello\t World!");
            Console.WriteLine("Hello \nWorld");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");
        }
    }
}
