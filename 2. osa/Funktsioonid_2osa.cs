using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOsad._2._osa
{
    internal class Funktsioonid_2osa
    {
        public static List<string> Sonad()
        {
            List<string> sonad = new List<string>();
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Nimi");
                sonad.Add(Console.ReadLine());
            }
            return sonad;
        }
        public static Isik[] Isikud(int k, string[] nimed, string[] aadressid)
        {
            Isik[] isikud = new Isik[k];

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(i);
                //isikud[i] = new Isik();
                isikud[i] = new Isik
                {
                    Nimi = nimed[i],
                    Vanus = i + 10,
                    Isikukood = "12345678901" + i,
                    Aadress = aadressid[i]
                };
            }
            return isikud;
        }
        public static List<Isik> Isikud2(int p, string[] nimed, string[] aadressid)
        {
            List<Isik> isikud2 = new List<Isik>();
            for (int j = p - 1; j > -1; j--)
            {
                Console.WriteLine(j);
                Isik isik = new Isik
                {
                    Nimi = nimed[j],
                    Vanus = 50,
                    Isikukood = "11223344556",
                    Aadress = aadressid[j]
                };
                isikud2.Add(isik);
            }
            return isikud2;
        }
        public static double[] Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud komadega eraldatult: ");
            string sisend = Console.ReadLine();
            string[] numbrid = sisend.Split(',');
            double[] arvud = new double[numbrid.Length];

            for (int i = 0; i < numbrid.Length; i++)
            {
                arvud[i] = double.Parse(numbrid[i].Trim());
            }
            return arvud;
        }
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = 0;
            double korrutis = 1;

            foreach (double arv in arvud)
            {
                summa += arv;
                korrutis *= arv;
            }
            double keskmine = summa / arvud.Length;
            return Tuple.Create(summa, korrutis, keskmine);
        }
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = 0;
            Inimene vanim = inimesed[0];
            Inimene noorim = inimesed[0];

            foreach (var inimene in inimesed)
            {
                summa += inimene.Vanus;

                if (inimene.Vanus > vanim.Vanus)
                    vanim = inimene;

                if (inimene.Vanus < noorim.Vanus)
                    noorim = inimene;
            }

            double keskmine = summa / inimesed.Count;
            return Tuple.Create(summa, keskmine, vanim, noorim);
        }
        public static void KuniMärksõnani(string märksõna, string fraas)
        {
            List<string> sisestused = new List<string>();
            string sisend;
            do
            {
                Console.WriteLine(fraas);
                sisend = Console.ReadLine();
                sisestused.Add(sisend);
            }
            while (sisend != märksõna);
            Console.WriteLine("Sisestused:");
            foreach (string s in sisestused)
            {
                Console.WriteLine(s);
            }
        }
        public static void ArvaArv()
        {
            Random random = new Random();
            int arv = random.Next(1, 101);
            int katseArv = 0;
            int sisestus = 0;
            int katseid = 5;
            Console.WriteLine("Arva ära number vahemikus 1-100");
            do
            {
                Console.WriteLine("Sisesta number:");
                sisestus = int.Parse(Console.ReadLine());
                katseArv++;
                if (sisestus < arv)
                    Console.WriteLine("Liiga väike!");
                else if (sisestus > arv)
                    Console.WriteLine("Liiga suur!");
                else
                    Console.WriteLine($"Õige! Arvasid ära {katseArv} katsega.");
            }
            while (sisestus != arv && katseArv < katseid);
        }
    }
}
