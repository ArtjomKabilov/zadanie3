using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Startclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast");




            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, "+ eesnimi);
            if (eesnimi.ToLower() =="juku")
            {
                Console.WriteLine("Lähme koju tee jooma, " + eesnimi + "me tahame lahme kinno, kui palju sa oled");
                int aasta =int.Parse(Console.ReadLine());
                if (aasta <6 && aasta >=0)
                {
                    Console.WriteLine("Tasuta pilet");
                }
                else if (aasta >=6 && aasta <= 14)
                {
                    Console.WriteLine("Laste pilet");
                }
                else if (aasta >= 15 && aasta <= 65)
                {
                    Console.WriteLine("Täispilet");
                }
                else if (aasta >= 66 && aasta <= 120)
                {
                    Console.WriteLine("Sooduspilet");
                }

                else 
                {
                    Console.WriteLine("Viga andmetega!");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole, " + eesnimi);
            }


            Console.WriteLine("Esimene arv");
            int arv = int.Parse(Console.ReadLine());
            Console.WriteLine("teine arv");
            int b =int.Parse(Console.ReadLine());
            //Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv,b, arv * b);
            Console.WriteLine("Znak");
            string znak = Console.ReadLine();
            if (znak == "+" )
            {
                Console.WriteLine(arv + b);
            }
            else if (znak == "-")
            {
                Console.WriteLine(arv - b);
            }
            else if (znak == "*")
            {
                Console.WriteLine(arv * b);
            }
            else if (znak == "/")
            {
                Console.WriteLine(arv / b);
            }




            Console.ReadLine();
            
        }
    }
}
