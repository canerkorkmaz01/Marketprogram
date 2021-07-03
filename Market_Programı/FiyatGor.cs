using Entity;
using ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class FiyatGor : Form
    {
        public FiyatGor()
        {
            InitializeComponent();
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Urunler u = new Urunler();
                u.BarkodNo = txtBarkod.Text;
                UrunlerORM.UrunFiyatıGor(u);
                txtBarkod.Clear();
                txtUrunAdi.Text = (string)UrunlerORM.UrunFiyatıGor(u).Rows[0]["UrunAdi"];
                txtFiyat.Text = UrunlerORM.UrunFiyatıGor(u).Rows[0]["SatisFiyati"].ToString();
            }
            catch (Exception) {; }
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
