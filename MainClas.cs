using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24
{
    class MainClas
    {
        public static void Main(string[] args)
        {
            /*Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World! Hea Päev!"); //"" строка  '' символ
            // I.osa Andmetüübid, If, Case, Random, Alamfunktsioonid
            /*
             * 
             * если надо заблокировать целые абзацы
             * 
             * 
             */
            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.32423234;
            float arv1 = 2;


            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n" + tekst);
            Console.WriteLine("{1}Tere!\n {0}", tekst, arv);

            // Вызов функции для обработки Juku
            FunktsioonideClass.Juku(tekst);

            Console.Write("Arv 2 :");
            int arv2 = int.Parse(Console.ReadLine());
            arv = FunktsioonideClass.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);

            // Вызов функции для рандома
            Console.WriteLine("Switch'i kasutamine");
            string randomResult = FunktsioonideClass.Random();
            Console.WriteLine(randomResult);

            Console.ReadKey();
        }
    }
}
