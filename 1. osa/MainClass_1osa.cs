using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOsad._1._osa
{
    internal class MainClass_1osa
    {
        public static void Main(string[] args)
        {
            //I.osa Andmetuubid, If, Case, Random, Alamfunktsioonid
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World");

            //I.osa Andmetuubid, if, case, random, alamfunktsioonid
            /* многострочный комментарий
             * 
             */
            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.4568685;
            float arv1 = 2;
            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n" + tekst);
            Console.WriteLine("{1} Tere! {0}", tekst, arv); //индекс прописывается по местоположению перемнной после запятой


            /* e<6 aastad  - tasuta
            6-14 - lastepilet
            15-65 - täispilet
            >65 - sooduspilet
            <0 ja >100 viga andmetega*/
            Console.Write("\nMis on sinu nimi? ");
            tekst = Console.ReadLine();
            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Laheme kinno!");
                try
                {
                    Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100) // "|| - OR", "&& - AND"
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus > 0 && vanus <= 6)
                    {
                        Console.WriteLine("Tasuta");
                    }
                    else if (vanus < 15)
                    {
                        Console.WriteLine("Lastepilet");
                    }
                    else if (vanus < 65)
                    {
                        Console.WriteLine("Täispilet");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Olen hoivatud!");
            }

            Console.WriteLine("Sisesta arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());
            arv1 = Funktsioonid_1osa.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);

            Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("Switchi kasutamine");
            tekst = Funktsioonid_1osa.switchkas(tekst);
            Console.WriteLine(tekst);
            Console.ReadLine();

            Console.WriteLine("1) Mis sinu nimi on? ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("2) Mis sinu nimi on? ");
            string nimi2 = Console.ReadLine();
            Console.WriteLine("{0} ja {1}, teie olete pinginaabrid!", nimi1, nimi2);
            Console.WriteLine();

            Console.WriteLine("1 Seina pikkus: ");
            double sein1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 Seina pikkus: ");
            double sein2 = Convert.ToDouble(Console.ReadLine());
            double pind = Funktsioonid_1osa.pindala(sein1, sein2);
            Console.WriteLine("Poranda pindala on {0}. Kas soovite teha remonti? (jah/ei)", pind);
            string vastus = Console.ReadLine();
            double kokku = Funktsioonid_1osa.hind(vastus, pind);
            Console.WriteLine("Poranda vahetuse maksumus: {0}.", kokku);
            Console.WriteLine();

            //Leia 30% hinnasoodustusega hinna põhjal alghind
            Console.WriteLine("Mis hind on?");
            double hind = Convert.ToDouble(Console.ReadLine());
            double alghind = Funktsioonid_1osa.hind30(hind);
            Console.WriteLine("Alghind on: {0}", alghind);
            Console.WriteLine();

            //Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).
            Console.WriteLine("Milline temperatuur toas on?");
            double temp = Convert.ToDouble(Console.ReadLine());
            vastus = Funktsioonid_1osa.temperatuur(temp);
            Console.WriteLine(vastus);
            Console.WriteLine();

            //Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
            Console.WriteLine("Mis kasvu sina oled?");
            double kasv = Convert.ToDouble(Console.ReadLine());
            vastus = Funktsioonid_1osa.pikkus(kasv);
            Console.WriteLine(vastus);
            Console.WriteLine();

            //Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk (mitu tingimusplokki võib olla üksteise sees).
            Console.WriteLine("Mis kasvu sina oled?");
            double kasv2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta oma sugu: ");
            string sugu = Console.ReadLine();
            vastus = Funktsioonid_1osa.sugupikkus(kasv2, sugu);
            Console.WriteLine(vastus);
            Console.WriteLine();

            //Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba.
            //Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
            int pkogus = 0;
            int skogus = 0;
            int lkogus = 0;

            Console.WriteLine("Kas soovid piima? (jah/ei)");
            string vastuspiim = Console.ReadLine();
            if (vastuspiim.ToLower() == "jah")
            {
                Console.WriteLine("Mitu tükki soovid?");
                pkogus = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Kas soovid saia? (jah/ei)");
            string vastussai = Console.ReadLine();
            if (vastussai.ToLower() == "jah")
            {
                Console.WriteLine("Mitu tükki soovid?");
                skogus = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Kas soovid leiba? (jah/ei)");
            string vastusleib = Console.ReadLine();
            if (vastusleib.ToLower() == "jah")
            {
                Console.WriteLine("Mitu tükki soovid?");
                lkogus = int.Parse(Console.ReadLine());
            }
            vastus = Funktsioonid_1osa.ostukorv(vastuspiim, vastussai, vastusleib, pkogus, skogus, lkogus);
            Console.WriteLine(vastus);
            Console.WriteLine();
        }
    }
}
