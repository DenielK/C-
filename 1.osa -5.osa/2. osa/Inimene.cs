using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOsad._2._osa
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Statistika(List<Inimene> inimesed)
        {


        }
    }
}
