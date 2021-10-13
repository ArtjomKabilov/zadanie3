using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Harjutus
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta nimi 1");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Kirjuta nimi 2");
            string nimi2 = Console.ReadLine();
            if (nimi1.ToLower()=="artjom" && nimi2.ToLower()=="georgi")
            {
                Console.WriteLine(nimi1 + " pinginaabrid " + nimi2 );
            }
            else if (nimi1.ToLower() == "georgi" && nimi2.ToLower() == "artjom")
            {
                Console.WriteLine(nimi1 + " pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "jaan" && nimi2.ToLower() == "nikita")
            {
                Console.WriteLine(nimi1 + " pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "nikita" && nimi2.ToLower() == "jaan")
            {
                Console.WriteLine(nimi1 + " pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "artem" && nimi2.ToLower() == "nikita")
            {
                Console.WriteLine(nimi1 + " pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "nikita" && nimi2.ToLower() == "artem")
            {
                Console.WriteLine(nimi1 + " pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "jaan" && nimi2.ToLower() == "artem")
            {
                Console.WriteLine(nimi1 + " ie ole pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "artem" && nimi2.ToLower() == "jaan")
            {
                Console.WriteLine(nimi1 + " ei ole pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "nikita" && nimi2.ToLower() == "artjom")
            {
                Console.WriteLine(nimi1 + " ei ole pinginaabrid " + nimi2);
            }
            else if(nimi1.ToLower() == "artjom" && nimi2.ToLower() == "nikita")
            {
                Console.WriteLine(nimi1 + " ei ole pinginaabrid " + nimi2);
            }
            else
            {
                Console.WriteLine("ei ole");
            }

            Console.ReadLine();
        }
    }
}
