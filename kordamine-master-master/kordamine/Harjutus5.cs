﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Harjutus5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta temperatuur");
            decimal temp = decimal.Parse(Console.ReadLine());
            if (temp < 18)
            {
                Console.WriteLine(temp + "see väike temperatuur");
            }
            else if (temp > 18)
            {
                Console.WriteLine(temp + "see suur temperatuur");
            }
            else if (temp == 18)
            {
                Console.WriteLine(temp + "see normaalne temperatuur");

            }
            Console.ReadLine();
        }
    }
}
