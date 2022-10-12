using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockapóker.sajatOsztalyok
{
    public class Leosztas
    {
        protected List<int> kockak = new List<int>();

        public void ujLeosztas()
        {
            kockak = Keveres();
        }

        public int Pont { get; set; }
        public Leosztas()
        {
            kockak = Keveres();
        }


        private List<int> Keveres()
        {
            List<int> k = new List<int>();
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 5; i++)
            {
                k.Add(rnd.Next(1, 7));
            }
            return k;
        }

        public override string ToString()
        {
            StringBuilder tmp = new StringBuilder("");
            foreach (var kocka in kockak)
            {
                tmp.Append($"{kocka} ");
            }
            return tmp.ToString();
        }

        public int MilyenErtek(int hanyadikKocka)
        {
            return kockak[hanyadikKocka];
        }

        public void LeosztasBeallitasa(List<int> kockak)
        {
            this.kockak = kockak;
        }

        public string LeosztasErteke()
        {

            kockak.Sort();
            Dictionary<int, int> stat = Statisztika(kockak);
            string eredmeny = "";

            if (stat.Count == 1)
            {
                int poker = stat.First().Key;
                eredmeny = $" {poker} Nagypóker";
                Pont = 8000 + poker;

            }
            else if (stat.Count == 5)
            {
                eredmeny = KissorNagysorSemmi(stat);
            }
            else if (stat.Count == 2)
            {
                eredmeny = PokerFull(stat);
            }
            else if (stat.Count == 3)
            {
                eredmeny = Drill2Par(stat);
            }
            else
            {
                int par = stat.OrderByDescending(x => x.Value).First().Key;
                eredmeny = $" {par} Pár";
                Pont = par;
            }
            return eredmeny;
        }

        private string Drill2Par(Dictionary<int, int> stat)
        {
            string eredmeny;
            int drill = stat.OrderByDescending(x => x.Value).First().Key;
            if (stat.ContainsValue(3))
            { 
                eredmeny = $" {drill} Drill";
                Pont = 100 * drill;
            }
            else
            {
                List<int> parok = new List<int>();
                foreach (var item in stat)
                {
                    if (item.Value == 2)
                    {
                        parok.Add(item.Key);
                    }
                }
                int max = parok.Max();
                int min = parok.Min();
                eredmeny = $"{max} - {min} pár";
                Pont = 10 * max + min;
            }
            return eredmeny;
        }

        private string PokerFull(Dictionary<int, int> stat)
        {
            string eredmeny;
            int elsoTag = stat.OrderByDescending(x => x.Value).First().Key;
            int masodikTag = stat.OrderBy(x => x.Value).First().Key;
            if (stat.ContainsValue(4))
            { 
                eredmeny = $" {elsoTag} Póker";
                Pont = 7000 + elsoTag;
            }
            else
            { 
                eredmeny = $"{elsoTag} - {masodikTag} Full";
                Pont = 1000 * elsoTag + masodikTag;
            }
            return eredmeny;
        }

        private string KissorNagysorSemmi(Dictionary<int, int> stat)
        {
            string eredmeny;
            if (!stat.ContainsKey(1))
            {
                eredmeny = $"Nagysor";
                Pont = 7020;
            }
            else if (!stat.ContainsKey(6))
            {
                eredmeny = $"Kissor";
                Pont = 7010;
            }
            else
            {
                eredmeny = "Semmi";
                Pont = 0;
            }
            return eredmeny;
        }

        private Dictionary<int, int> Statisztika(List<int> kockak)
        {
            Dictionary<int, int> tmp = new Dictionary<int, int>();
            foreach (var k in kockak)
            {
                if (tmp.ContainsKey(k))
                {
                    tmp[k]++;
                }
                else
                {
                    tmp.Add(k, 1);
                }
            }
            return tmp;
        }
    }
}
