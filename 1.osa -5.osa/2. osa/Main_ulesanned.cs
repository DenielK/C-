using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOsad._2._osa
{
    internal class Main_ulesanned
    {
        public static void Main(string[] args)
        {
            //1. Juhuslike arvude ruudud
            (int[] arvud, int[] ruudud) = Arvu.GenereeriRuudud(-100, 100);
            for (int i = 0; i < ruudud.Length; i++)
            {
                Console.WriteLine($"{arvud[i]} -> {ruudud[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //2. Viie arvu analüüs
            double[] arvud2 = Funktsioonid_2osa.Tekstist_arvud();
            var tulemus = Funktsioonid_2osa.AnalüüsiArve(arvud2);
            Console.WriteLine("Arvude analüüs:");
            Console.WriteLine($"Sisestatud arvud: {string.Join(",", arvud2)}");
            Console.WriteLine($"Arvude summa: {tulemus.Item1}");
            Console.WriteLine($"Arvude korrutis: {tulemus.Item2}");
            Console.WriteLine($"Arvude keskmine: {tulemus.Item3}");
            Console.WriteLine();
            Console.WriteLine();

            //3. Nimed ja vanused
            List<Inimene> inimesed = new List<Inimene>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Sisesta nimi {i + 1}: ");
                string nimi = Console.ReadLine();
                Console.WriteLine($"Sisesta vanus {i + 1}: ");
                int vanus = int.Parse(Console.ReadLine());
                inimesed.Add(new Inimene(nimi, vanus));
            }
            var tulemus2 = Funktsioonid_2osa.Statistika(inimesed);
            Console.WriteLine("Statistika: ");
            Console.WriteLine($"Vanuste summa: {tulemus2.Item1}");
            Console.WriteLine($"Keskmine vanus: {tulemus2.Item2}");
            Console.WriteLine($"Vanim inimene: {tulemus2.Item3.Nimi}, {tulemus2.Item3.Vanus} aastat");
            Console.WriteLine($"Noorim inimene: {tulemus2.Item4.Nimi}, {tulemus2.Item4.Vanus} aastat");
            Console.WriteLine();
            Console.WriteLine();

            //4. "Osta elevant ära!"
            Funktsioonid_2osa.KuniMärksõnani("elevant", "Osta elevant!");
            Console.WriteLine();
            Console.WriteLine();

            //5.Arvamise mäng
            string vastus;
            do
            {
                Funktsioonid_2osa.ArvaArv();
                Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
                vastus = Console.ReadLine().ToLower();
                Console.WriteLine();
            }
            while (vastus == "jah");

            Console.WriteLine("Aitäh mängimast! Näeme jälle!");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}