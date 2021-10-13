using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Harjutus2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta cm1 sein");
            decimal cm1 =Math.Abs(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Kirjuta cm2 sein2");
            decimal cm2 = Math.Abs(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Põranda pindala");
            Console.WriteLine(cm1 * cm2 +"cm2");
            Console.WriteLine("Kas tahad remondi teha");
            string otvet = Console.ReadLine();
            if (otvet=="jah")
            {
                Console.WriteLine("Kui suur ruud meetri hind");
                decimal hind = decimal.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(hind * ((cm1/100) * (cm2/100)),2)+"- summa");
            }
            else
            {
                Console.WriteLine("Head aega");
            }





            Console.ReadLine();
        }
    }
}
