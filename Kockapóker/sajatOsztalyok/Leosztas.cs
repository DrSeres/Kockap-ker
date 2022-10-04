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
                k.Add(rnd.Next(1, 6));
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
    }
}
