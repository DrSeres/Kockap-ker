using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kockapóker.sajatOsztalyok;

namespace Kockapóker
{
    public partial class Form1 : Form
    {
        List<PictureBox> jatekosKepek = new List<PictureBox>();
        List<PictureBox> gepKepek = new List<PictureBox>();


        Jatekos j;
        Jatekos g;
        public Form1()
        {
            InitializeComponent();
            PictureBoxokBeallitasa();
            JatekosokBeallitasa();

            VezerlokBeallitasa();

            Kiertekeles();

        }

        private void Kiertekeles()
        {
            lblJatekosErtek.Text = j.LeosztasErtek;
        }
        private void VezerlokBeallitasa()
        {
            lblGepErtek.Text = "";
            lblJatekosErtek.Text = "";
        }

        private void JatekosokBeallitasa()
        {
            List<int> kockak = new List<int>() { 2, 2, 2, 3, 3};
            j = new Jatekos("Szerencsés Pista", jatekosKepek);

            j.LeosztasBeallitasa(kockak);

            g = new Jatekos("Gép", gepKepek);

            j.kepekBeallitasa();
            g.kepekBeallitasa();
        }

        private void PictureBoxokBeallitasa()
        {
            jatekosKepek.Add(pbElsoJatekos1);
            jatekosKepek.Add(pbElsoJatekos2);
            jatekosKepek.Add(pbElsoJatekos3);
            jatekosKepek.Add(pbElsoJatekos4);
            jatekosKepek.Add(pbElsoJatekos5);
           

            gepKepek.Add(pbMasodikJatekos1);
            gepKepek.Add(pbMasodikJatekos2);
            gepKepek.Add(pbMasodikJatekos3);
            gepKepek.Add(pbMasodikJatekos4);
            gepKepek.Add(pbMasodikJatekos5);
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(j.Kockak.MilyenErtek(0).ToString());
            //MessageBox.Show(j.Kockak.MilyenErtek(1).ToString());
            //MessageBox.Show(j.Kockak.MilyenErtek(2).ToString());
            //MessageBox.Show(j.Kockak.MilyenErtek(3).ToString());
            //MessageBox.Show(j.Kockak.MilyenErtek(4).ToString());
            //MessageBox.Show(j.ToString());
            //j.ujLeosztas();
            //MessageBox.Show(j.ToString());
            
            Application.Exit();
        }
    }
}
