using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class MunferitSatis : Form
    {
        public MunferitSatis()
        {
            InitializeComponent();
        }

        private void MunferitSatis_Load(object sender, EventArgs e)
        {
            cboAdet.SelectedIndex = 0;
            txtBarkod.MaxLength = 13;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                Urunler u = new Urunler();
                Satis s = (Satis)Application.OpenForms["Satis"];
                u.BarkodNo = txtBarkod.Text;
                u.UrunAdi = UrunlerORM.UrunListele(u).Rows[0]["UrunAdi"].ToString();
                u.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
                u.Toplam = Convert.ToDecimal(u.SatisFiyati * Convert.ToInt32(cboAdet.Text));
                UrunlerORM.dt.Rows.Add(u.BarkodNo, u.UrunAdi, u.SatisFiyati.ToString("N2"), cboAdet.Text, u.Toplam.ToString("N2"));
                s.dataGridView1.DataSource = UrunlerORM.dt;
                Tables.DataGridViewUrunListele(s.dataGridView1);
                this.Dispose();
            }
            catch (Exception) {; }
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
