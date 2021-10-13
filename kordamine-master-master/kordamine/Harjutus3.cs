using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Harjutus3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta hind");
            decimal hind =Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal soodust = hind * 30 / 100;
            Console.WriteLine(hind-soodust + " euro");

            Console.ReadLine();



        }
    }
}
