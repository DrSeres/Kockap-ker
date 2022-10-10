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
            //kockak lista

            kockak.Sort();
            if (kockak[0] == kockak[1] && kockak[1] == kockak[2] && kockak[2] == kockak[3] && kockak[3] == kockak[4])
            {
                return $"{kockak[0]} Nagy Póker";
            }
            else if (kockak[0] == 1 && kockak[1] == 2 && kockak[2] == 3 && kockak[3] == 4 && kockak[4] == 5)
            {
                    return $"Kissor";
            }
            else if (kockak[0] == 2 && kockak[1] == 3 && kockak[2] == 4 && kockak[3] == 5 && kockak[4] == 6)
            {
                return $"Nagysor";
            }
            else if (kockak[0] == kockak[1] && kockak[1] == kockak[2] && kockak[2] == kockak[3])
            {
                return $"{kockak[0]} Póker";
            }
            else if (kockak[1] == kockak[2] && kockak[2] == kockak[3] && kockak[3] == kockak[4])
            {
                return $"{kockak[1]} Póker";
            }
            else if (kockak[0] == kockak[1] && kockak[2] == kockak[3] && kockak[3] == kockak[4])
            {
                return $"{kockak[2]} - {kockak[0]} Full";
            }
            else if (kockak[0] == kockak[1] && kockak[1] == kockak[2] && kockak[3] == kockak[4])
            {
                return $"{kockak[0]} - {kockak[3]} Full";
            }
            return "Semmi";
        }
    }
}
