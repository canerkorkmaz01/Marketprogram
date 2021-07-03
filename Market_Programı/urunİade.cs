using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class urunİade : Form
    {
        public urunİade()
        {
            InitializeComponent();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Urunİade ui = new Urunİade();
                ui.BarkodNo = txtBarkod.Text;
                txtUrunAdi.Text = UrunİadeORM.İadeBilgisi(ui).Rows[0]["UrunAdi"].ToString();
                txtFiyat.Text = UrunİadeORM.İadeBilgisi(ui).Rows[0]["SatisFiyati"].ToString();
                dataGridView1.DataSource = UrunİadeORM.İadeBilgileri();
            }
            catch (Exception) {; }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Urunİade ui = new Urunİade();
                ui.PersonelID = Tools.PersonelID;
                ui.BarkodNo = txtBarkod.Text;
                ui.UrunAdi = txtUrunAdi.Text;
                ui.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                ui.Miktar = Convert.ToInt32(txtMiktar.Text);
                ui.Toplam = Convert.ToDecimal(ui.Miktar * ui.Fiyat);
                ui.İadeSebeb = txtİadeSebeb.Text;
                ui.Tarih = DateTime.Now;
                bool deger = UrunİadeORM.İadeEkle(ui);
                urunİade_Load(null, null);
                if (deger)
                {
                    MessageBox.Show("İADELİ ÜRÜN BAŞARIYLA EKLENDİ", "İADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("İADE EKLENİRKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                bool deger = UrunİadeORM.İadeSil(id);
                if (deger)
                    MessageBox.Show("İADE EDİLEN ÜRÜN SİLİNDİ", "İADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("İADE SİLİNRKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                urunİade_Load(null, null); 
            }
            else MessageBox.Show("SİLİNECEK BİR ÜRÜN SEÇİNİZ","ÜRÜN SİL",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Urunİade ui = new Urunİade();
                ui.İadeId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                ui.BarkodNo = txtBarkod.Text;
                ui.UrunAdi = txtUrunAdi.Text;
                ui.Fiyat =Convert.ToDecimal(txtFiyat.Text);
                ui.Miktar = Convert.ToInt32(txtMiktar.Text);
                ui.Toplam = Convert.ToDecimal(Convert.ToDecimal(txtFiyat.Text) * Convert.ToInt32(txtMiktar.Text));
                ui.İadeSebeb = txtİadeSebeb.Text;
                bool deger = UrunİadeORM.İadeGuncelle(ui);
                if (deger)
                    MessageBox.Show("İADE EDİLEN ÜRÜN GÜNCELLENDİ", "İADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("İADE GÜNCELLENİRKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                urunİade_Load(null, null); 
            }
            else MessageBox.Show("GÜNCELLENECEK BİR ÜRÜN SEÇİNİZ", "ÜRÜN GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void urunİade_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UrunİadeORM.İadeBilgileri();
            Tables.DataGridViewİadeler(dataGridView1);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                ctrl.Text = string.Empty;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkod.Text =dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunAdi.Text =dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMiktar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtİadeSebeb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
