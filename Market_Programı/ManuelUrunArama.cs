using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class ManuelUrunArama : Form
    {
        public ManuelUrunArama()
        {
            InitializeComponent();
        }
    
        private void ManuelUrunArama_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            dataGridView1.DataSource = UrunlerORM.Urunler();
            Keypad k = new Keypad();
            Tables.DataGridViewUrunArama(dataGridView1);
            k.Keyboards(flowLayoutPanel1);
            Tools.Keypad = 1;
        }

        /// <summary>
        /// TextBox İçine Yazılan Metini Veritabnında Arama Yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Urunler u = new Urunler();
                u.UrunAdi = txtArama.Text;
                dataGridView1.DataSource = UrunlerORM.UrunArama(u);
                Tables.DataGridViewUrunArama(dataGridView1);
            }
            catch (Exception) {; }
        }

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        /// <summary>
        /// DataGridView Seçilen Ürünleri Satışlar Formundaki DataGridView Gönderirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Tools.UrunArama == false)
                {
                    Urunler u = new Urunler();
                    Satis s = (Satis)Application.OpenForms["Satis"];
                    u.BarkodNo = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    u.UrunAdi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    u.SatisFiyati = (decimal)dataGridView1.CurrentRow.Cells[6].Value;
                    u.Toplam = Convert.ToDecimal(u.SatisFiyati * Convert.ToInt32(s.cboAdet.Text));
                    UrunlerORM.dt.Rows.Add(u.BarkodNo, u.UrunAdi, u.SatisFiyati.ToString("N2"), s.cboAdet.Text, u.Toplam.ToString("N2"));
                    s.dataGridView1.DataSource = UrunlerORM.dt;
                    Tables.DataGridViewUrunListele(s.dataGridView1);
                    this.Dispose(); 
                }
                else if(Tools.UrunArama == true)
                {
                    Satis s = (Satis)Application.OpenForms["Satis"];
                    HizliSatisAta hsa = (HizliSatisAta)Application.OpenForms["HizliSatisAta"];
                    HizliSatis hs = new HizliSatis();
                    HizliSatisORM hsORM = new HizliSatisORM();
                    hs.HizliSatisId = Tools.btnTag;
                    hs.Barkod = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    hs.UrunAdi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    hsORM.HizlSatisEkle(hs);
                    s.HizliSatisButonlari(Tools.hizliSatisButon);

                    hsa.Dispose();
                    this.Dispose();
                }
            }
            catch (Exception) {; }
        }
    }
}
