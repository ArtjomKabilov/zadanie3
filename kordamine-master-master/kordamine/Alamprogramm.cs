using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Alamprogramm
    {
        public static int Korruta(int arv1, int arv2)
        {
            return (arv1+arv2) /2;
        }
        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        static void Main(string[] args)
        {

            Console.WriteLine("napishi 4islo 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("napishi 4islo 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"({a} + {b} / 2) = {Korruta(a, b)}");

            Console.ReadLine();

        }
    }
}
