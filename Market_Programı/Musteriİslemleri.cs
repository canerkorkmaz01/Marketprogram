using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Musteriİslemleri : Form
    {
        public Musteriİslemleri()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMusteriekle_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle
            {
                MdiParent=this.MdiParent
            };
            me.Show();
        }

        private void btnMusteriHesaplari_Click(object sender, EventArgs e)
        {
            MusteriHesaplari mh = new MusteriHesaplari
            {
                MdiParent =this.MdiParent
            };
            mh.Show();
        }

        private void btnTumBorçlar_Click(object sender, EventArgs e)
        {
            MusteriHesaplari mh = new MusteriHesaplari();
            mh.RaporAl("prc_Musteriler_MusteriGetir");
        }
    }
}
