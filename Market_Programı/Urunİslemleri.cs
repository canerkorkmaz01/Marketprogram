using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Urunİslemleri : Form
    {
        public Urunİslemleri()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UrunListesi"]== null)
            {
                UrunListesi ul = new UrunListesi
                {
                    MdiParent = this.MdiParent
                };
                ul.Show(); 
            }
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UrunEkle"] == null)
            {
                UrunEkle ue = new UrunEkle
                {
                    MdiParent = this.MdiParent
                };
                ue.Show(); 
            }
        }

        private void btnUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KategoriEkle"] == null)
            {
                KategoriEkle ke = new KategoriEkle
                {
                    MdiParent = this.MdiParent
                };
                ke.Show(); 
            }
        }
        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StokGir"] ==null)
            {
                StokGir sg = new StokGir
                {
                    MdiParent = this.MdiParent
                };
                sg.Show(); 
            }
        }

        private void btnSatisDuzenle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SatisListesi"] == null)
            {
                SatisListesi sl = new SatisListesi
                {
                    MdiParent = this.MdiParent
                };
                sl.Show();
            }
        }

        private void btnUrunİade_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Urunİade"] == null)
            {
                urunİade ui = new urunİade
                {
                    MdiParent = this.MdiParent
                };
                ui.Show();
            }
        }
    }
}
