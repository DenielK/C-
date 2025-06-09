using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOsad._2._osa
{
    internal class MainClass_2osa
    {
        public static void Main(string[] args)
        {
            //II.osa Kordused, Massivid, Listid, Klassid
            List<string> sonad = Funktsioonid_2osa.Sonad();
            foreach (string item in sonad)
            {
                Console.WriteLine(item);
            }

            Isik isik1 = new Isik("Juku", 18, "12345678901", "Tallinn");
            isik1.PrindiInfo();
            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Aadress = "Tartu";
            isik2.Isikukood = "10987654321";
            isik2.Sugu = Sugu.Naine;
            isik2.PrindiInfo();

            Console.WriteLine("----------for++/Massiv--------------");
            string[] nimed = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            string[] aadressid = new string[10] { "Tallinn", "Tartu", "Narva", "Parnu", "Sillamae", "Loksa", "Kehra", "Paid", "Johvi", "Viljandi" };
            int i;
            Isik[] isikud = Funktsioonid_2osa.Isikud(nimed.Length, nimed, aadressid);
            for (i = 0; i < nimed.Length; i++)
            {
                isikud[i].PrindiInfo();
            }
            Console.WriteLine("----------for/List--------------");
            List<Isik> isikud2 = Funktsioonid_2osa.Isikud2(nimed.Length, nimed, aadressid);
            foreach (Isik isik in isikud2)
            {
                isik.PrindiInfo();
            }
            Console.WriteLine("------------while------------");
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("------------do------------");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);
        }
    }
}
