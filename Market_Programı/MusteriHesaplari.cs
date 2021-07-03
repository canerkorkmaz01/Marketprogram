using Entity;
using FastReport;
using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class MusteriHesaplari : Form
    {
        public MusteriHesaplari()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Toplam müşteri Sayısını Getirir
        /// </summary>
        private void Toplam()
        {
            for (int i = 1; i <= dataGridView1.RowCount; i++)
            {
                lblToplamMusteri.Text = "Müşteri Sayısı" + " " + i;
            }
            
        }

        /// <summary>
        /// Rapor Oluşturmak İçin Kullanılan Metot
        /// </summary>
        /// <param name="prc"></param>
        public void RaporAl(string prc)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(prc, Tools.Baglanti);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\MusteriBorcRaporlari.FRX");
                report.Show();
                //report.Design();
            }
        }
        private void MusteriHesaplari_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            dataGridView1.DataSource= MusterilerORM.MusterileriGetir();
            Tables.DataGridViewMusteriler(dataGridView1);
            Toplam();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Müşteri Adında Arama Yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                Musteriler m = new Musteriler();
                m.Adi = txtAra.Text;
                dataGridView1.DataSource = MusterilerORM.MusteriAra(m);
                Tables.DataGridViewMusteriler(dataGridView1);
            }
            catch (Exception) {; }
        }

        /// <summary>
        /// Seçilen Duruma Göre Rapar Getirir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            if (rdBorclu.Checked == true)
                RaporAl("prc_Musteriler_BorcuOlanlar");
            else if(rdTum.Checked == true)
                RaporAl("prc_Musteriler_MusteriGetir");
        }

        /// <summary>
        /// Müşteri Hesdaplarını Düzenlemek İçin Kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHesap_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriId =(int) dataGridView1.CurrentRow.Cells[0].Value;
            m.Adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            m.Soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            m.Adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            m.Telefonu = dataGridView1.CurrentRow.Cells[4].Value.ToString();       
            m.Borc =(decimal) dataGridView1.CurrentRow.Cells[5].Value;
            m.Limit = (decimal)dataGridView1.CurrentRow.Cells[7].Value;

            if (dataGridView1.SelectedRows.Count !=0)
            {
                MusteriDuzenle md = new MusteriDuzenle(m)
                {
                    MdiParent = this.MdiParent
                };
                md.Show();
            }
            else MessageBox.Show("BİR MÜŞTERİ SEÇİNİZ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        /// <summary>
        /// Veritabanında Değişiklik Yapıldıgı Zaman 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MusterilerORM.MusterileriGetir();
            Tables.DataGridViewMusteriler(dataGridView1);
        }

        /// <summary>
        /// Seçilen müşterileri Silmek İçin Kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("SEÇİLEN MÜŞTERİ SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ","MÜŞTERİ SİL",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result ==DialogResult.Yes)
            {
                Musteriler m = new Musteriler();
                m.MusteriId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                bool deger = MusterilerORM.MusteriSil(m);
                if (deger)
                {
                    MessageBox.Show("MÜŞTERİ SİLİNDİ", "SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnYenile_Click(null, null);
                }
                else MessageBox.Show("MÜŞTERİ SİLİNİRKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
    }
}
