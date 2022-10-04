﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kockapóker.sajatOsztalyok
{
    class Gep : Jatekos
    {
        public Gep(string nev, List<PictureBox> kockaKepek) : base(nev, kockaKepek)
        {


        }
        public void kepekBeallitasa()
        {
            int i = 0;
            foreach (var k in kockaKepek)
            {
                switch (leosztas.MilyenErtek(i++))
                {
                    case 1:
                        k.Image = Properties.Resources.zold1;
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

                }
            }
        }
    }
}
