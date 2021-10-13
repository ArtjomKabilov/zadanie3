using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class zadanie2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage esimene arv:");
            Double arv1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Sisestage teine arv: ");
            Double arv2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Sisestage tehe:");
            string znak = Console.ReadLine();



            Double result = Alamprogramm.Eval(arv1.ToString()+znak+arv2.ToString());
            Console.WriteLine(result);
            for (int i = 0; i < result; i++)
            {
                Console.Write("Nurr, ");
            }
            Console.ReadLine();
        }
    }
}
