using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kockapóker.sajatOsztalyok
{
    public class Jatekos
    {
        protected List<PictureBox> kockaKepek = new List<PictureBox>();

        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        protected Leosztas leosztas = new Leosztas();

        public Leosztas Kockak
        {
            get { return leosztas; }
        }

        public override string ToString()
        {
            return $"{nev} - {leosztas.ToString()}";

        }

        public void LeosztasBeallitasa(List<int> kockak)
        {
            leosztas.LeosztasBeallitasa(kockak);
        }

        public Jatekos(string nev, List<PictureBox> kockaKepek)
        {
            Nev = nev;
            this.kockaKepek = kockaKepek; // akkor kell this ha ugyanaz a 2 név
        }

        public void ujLeosztas()
        {
            leosztas.ujLeosztas();
        }

        public void kepekBeallitasa()
        {
            int i = 0;
            foreach (var k in kockaKepek)
            {
                switch (leosztas.MilyenErtek(i++))
                {
                    case 1:
                        k.Image = Properties.Resources.kek1;
                        break;
                    case 2:
                        k.Image = Properties.Resources.kek2;
                        break;
                    case 3:
                        k.Image = Properties.Resources.kek3;
                        break;
                    case 4:
                        k.Image = Properties.Resources.kek4;
                        break;
                    case 5:
                        k.Image = Properties.Resources.kek5;
                        break;
                    case 6:
                        k.Image = Properties.Resources.kek6;
                        break;

                }
                //k.Image = kepValaszt();
            }
        }
        public string LeosztasErtek { get {
                return leosztas.LeosztasErteke();
            } }
        public int Pont
        {
            get { return leosztas.Pont; }
        }
    
    }
}
