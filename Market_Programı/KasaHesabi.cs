using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class KasaHesabi : Form
    {
        public KasaHesabi()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnKasaEkle_Click(object sender, EventArgs e)
        {
            KasaEkle ke = new KasaEkle
            {
                MdiParent=this.MdiParent
            };
            ke.Show();
        }

        private void btnKasaCikar_Click(object sender, EventArgs e)
        {
            KasaCikar kc = new KasaCikar
            {
                MdiParent = this.MdiParent
            };
            kc.Show();
        }

        private void btnKasaRaporu_Click(object sender, EventArgs e)
        {
            Tools.KasaRaporu = 2;
            KasaRaporu kr = new KasaRaporu
            {
                MdiParent = this.MdiParent
            };
            kr.Show();
        }
    }
}
