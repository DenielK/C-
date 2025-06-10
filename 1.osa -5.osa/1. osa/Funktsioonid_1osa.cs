using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOsad._1._osa
{
    internal class Funktsioonid_1osa
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = 0;
            kalkulaator = arv1 * arv2;
            return kalkulaator;
        }

        public static string switchkas(string tekst)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 8);
            Console.WriteLine(a);
            switch (a)
            {
                case 1: tekst = "E"; break;
                case 2: tekst = "T"; break;
                case 3: tekst = "K"; break;
                case 4: tekst = "N"; break;
                case 5: tekst = "R"; break;
                case 6: tekst = "L"; break;
                case 7: tekst = "P"; break;
                default:
                    tekst = "Tundmatu";
                    break;
            }
            return tekst;
        }
        public static double pindala(double sein1, double sein2)
        {
            double pind = sein1 * sein2;
            return pind;
        }
        public static double hind(string vastus, double pind)
        {
            double kokku = 0;
            if (vastus.ToLower() == "jah")
            {
                Console.WriteLine("Kui palju maksab ruutmeeter? ");
                double hind = Convert.ToDouble(Console.ReadLine());
                kokku = pind * hind;
            }
            else
            {
                Console.WriteLine("Head aega");
            }
            return kokku;
        }
        public static double hind30(double hind)
        {
            double alghind = hind * 1.3;
            return alghind;
        }
        public static string temperatuur(double temp)
        {
            string vastus;
            if (temp >= 18)
            {
                vastus = $"Temperatuur {temp} on soovitatav toatemperatuur talvel";
            }
            else
            {
                vastus = $"Temperatuur {temp} on liiga madal";
            }
            return vastus;
        }
        public static string pikkus(double kasv)
        {
            string pikkus;
            if (kasv <= 150)
            {
                pikkus = $"Sinu pikkus on {kasv}. Oled lühikest kasvu";
            }
            else if (kasv <= 190)
            {
                pikkus = $"Sinu pikkus on {kasv}. Oled keskmist kasvu";
            }
            else
            {
                pikkus = $"Sinu pikkus on {kasv}. Oled pikka kasvu";
            }
            return pikkus;
        }

        public static string sugupikkus(double kasv, string sugu)
        {
            string pikkus;
            if (sugu.ToLower() == "mees")
            {
                if (kasv <= 150)
                {
                    pikkus = $"Sinu pikkus on {kasv}. Oled lühikest kasvu";
                }
                else if (kasv <= 190)
                {
                    pikkus = $"Sinu pikkus on {kasv}. Oled keskmist kasvu";
                }
                else
                {
                    pikkus = $"Sinu pikkus on {kasv}. Oled pikka kasvu";
                }
            }
            else if (sugu.ToLower() == "naine")
            {
                if (kasv <= 100)
                {
                    pikkus = $"Sinu pikkus on {kasv}. Oled lühikest kasvu";
                }
                else if (kasv <= 170)
                {
                    pikkus = $"Sinu pikkus on {kasv}. Oled keskmist kasvu";
                }
                else
                {
                    pikkus = $"Sinu pikkus on {kasv}. Oled pikka kasvu";
                }
            }
            else
            {
                pikkus = "Tundmatu sugu";
            }
            return pikkus;
        }
        public static string ostukorv(string vastuspiim, string vastussai, string vastusleib, int pkogus, int skogus, int lkogus)
        {
            Random rnd = new Random();
            double phind = Math.Round(rnd.NextDouble() * 2.5 + 0.5, 2);
            double shind = Math.Round(rnd.NextDouble() * 2.5 + 0.5, 2);
            double lhind = Math.Round(rnd.NextDouble() * 2.5 + 0.5, 2);
            double psumma = 0;
            double ssumma = 0;
            double lsumma = 0;
            double summa = 0;
            int piimkogus = 0;
            int saikogus = 0;
            int leibkogus = 0;

            if (vastuspiim.ToLower() == "jah")
            {
                piimkogus = piimkogus + pkogus;
                psumma = piimkogus * phind;
            }
            if (vastussai == "jah")
            {
                saikogus = saikogus + skogus;
                ssumma = saikogus * shind;
            }
            if (vastusleib == "jah")
            {
                leibkogus = leibkogus + lkogus;
                lsumma = leibkogus * lhind;
            }
            summa = Math.Round(psumma + ssumma + lsumma, 2);
            string vastus = $"Piim:\tKogus: {pkogus} tk\tHind tk: {phind} €\tSumma: {psumma} €\nSai:\tKogus: {skogus} tk\tHind tk: {shind} €\tSumma: {ssumma} €\nLeib:\tKogus: {lkogus} tk\tHind tk: {lhind} €\tSumma: {lsumma} €\nKokku: {summa}";
            return vastus;
        }
    }
}
