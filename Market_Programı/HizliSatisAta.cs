using Entity;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class HizliSatisAta : Form
    {
        public HizliSatisAta()
        {
            InitializeComponent();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HizliSatisAta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Dispose();
        }

        private void HizliSatisAta_Load(object sender, EventArgs e)
        {
            txtBarkod.MaxLength = 13;
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Manuel Ürün Arama Sayfasını Açar Getirir Ürün Bulmak Butonlara Kısyayolunu eklemek İçin Kullanılır 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ManuelUrunArama"]== null)
            {
                Tools.UrunArama = true;
                ManuelUrunArama mua = new ManuelUrunArama();
                mua.Show(); 
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            Satis s = (Satis)Application.OpenForms["Satis"];
            HizliSatisORM hsORM = new HizliSatisORM();
            HizliSatis hs= new HizliSatis();
            hs.HizliSatisId = Tools.btnTag;
            hs.Barkod = txtBarkod.Text;
            hs.UrunAdi =(string) HizliSatisORM.HızlıSatisBarkod(hs).Rows[0]["UrunAdi"];
            hsORM.HizlSatisEkle(hs);
            s.FlowLayouyPanel1.Controls.Clear();
            s.HizliSatisButonlari(Tools.hizliSatisButon);
        }
    }
}
