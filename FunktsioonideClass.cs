using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TARgv24
{
    class FunktsioonideClass
    {
        //Console.WriteLine("Arvuda {0} ja {1} korrutis võrdub{2}", arv1, arv2, arv1 * arv2);
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = 0;
            kalkulaator = arv1 * arv2;
            return kalkulaator;
        }

        public static string Random()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 8); // Генерация случайного числа от 1 до 7
            string tekst = "";

            switch (a)
            {
                case 1: tekst = "E"; break;
                case 2: tekst = "T"; break;
                case 3: tekst = "K"; break;
                case 4: tekst = "N"; break;
                case 5: tekst = "R"; break;
                case 6: tekst = "L"; break;
                case 7: tekst = "P"; break;
                default: tekst = "Tundmatu"; break;
            }

            return tekst;
        }

        public static void Juku(string tekst)
        {
            if (tekst.ToLower() == "juku")
            {
                try
                {
                    Console.WriteLine("{0}\nKui vana sa oled?", tekst);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100) // && и, || или
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus <= 6)
                    {
                        Console.WriteLine("Tasuta!");
                    }
                    else if (vanus < 15)
                    {
                        Console.WriteLine("Lastepilet!");
                    }
                    else if (vanus < 65)
                    {
                        Console.WriteLine("Täispilet!");
                    }
                    else
                    {
                        Console.WriteLine("Sooduspilet!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Olen hõivatud!");
            }
        }
    }
}
