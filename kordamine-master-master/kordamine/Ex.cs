using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Ex
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Viberi zadanie ot 1 do 5");
            int C = int.Parse(Console.ReadLine());
            if (C==1)
            {
                int mult = 1;
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Number");
                    int set = Convert.ToInt32(Console.ReadLine());
                    sum += set;
                    mult = set + mult;
                }
                double avg = sum / 5;
                Console.WriteLine($"Nums AVG = {avg}\nNums SUM = {sum}\nNums multipiled = {mult}");

                Console.ReadLine();

            }

            if (C==2)
            {
                string text;
                do

                {
                    Console.WriteLine("Osta elevant ära!");
                    text = Console.ReadLine();

                } while (text != "elevant");
                Console.WriteLine("Elevant");

                Console.ReadLine();
            }



            if (C==3)
            {
                Random rand = new Random();
                int A = rand.Next(1, 10);//arvuti arv
                int AA;//kasutaja arv
                int K = 1;//katsed
                do
                {
                    Console.WriteLine($"{K} Katse. Mis arv?");
                    AA = int.Parse(Console.ReadLine());
                    K++;
                } while (AA!=A && K!=6);
                if (AA==A)
                {
                    Console.WriteLine("Palju õnne");
                }
                else
                {
                    Console.WriteLine("Proovi veel!");
                }

                Console.ReadLine();
            }
            if (C==4)
            {
                int arv;
                int[] arvud = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Sisesta {i+1} arv!");
                    arv = int.Parse(Console.ReadLine());
                    arvud[i] = arv;

                }
                int arv4=0;
                Array.Reverse(arvud);
                foreach (var a in arvud)
                {
                    arv4 = arv4 * 10 + a;  
                }
                Console.WriteLine(arv4);
                Console.ReadLine();
            }
            if (C==5)
            {
                int ridadearv = 10, veergudearv = 10;
                if (args.Length == 2)
                {
                    ridadearv = int.Parse(args[0]);
                    veergudearv = int.Parse(args[1]);
                }
                for (int rida = 1; rida <= ridadearv; rida++)
                {
                    for (int veerg = 1; veerg <= veergudearv; veerg++)
                    {
                        Console.Write("{0, 5}", rida * veerg);//5 kohta
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            
        }
    }
}
