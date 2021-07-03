using Entity;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class KategoriAta : Form
    {
        public KategoriAta()
        {
            InitializeComponent();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtKategoriAdi_TextChanged(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = txtKategoriAdi.Text.ToUpper();
            txtKategoriAdi.SelectionStart = txtKategoriAdi.Text.Length;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Satis satis = (Satis)Application.OpenForms["Satis"];
            HizliKategori hk = new HizliKategori();
            HizliKategoriORM hkORM = new HizliKategoriORM();
            hk.HizliBaslik = txtKategoriAdi.Text;
            hkORM.HizliKategoriEkle(hk);
            satis.HizliKategoriler();
            this.Dispose();
          
        }
    }
}
