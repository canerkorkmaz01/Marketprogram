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
    public partial class ToptanciHesaplari : Form
    {
        public ToptanciHesaplari()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void ToptanciHesaplari_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            dataGridView1.DataSource= TedarikciORM.TedarikciGetir();
            Tables.DataGridViewTedarikciler(dataGridView1);
            Toplam();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void txtBorcToplami_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtTumAldiklarim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtTumOdemeleri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TedarikciORM.TedarikciGetir();
            Tables.DataGridViewTedarikciler(dataGridView1);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Toplam Borç Sayılarını Veririr
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private decimal Borclar(int id)
        {
            decimal borc = 0;
            foreach (DataGridViewRow drv in dataGridView1.Rows)
            {
                borc +=Convert.ToDecimal( drv.Cells[id].Value);
            }
            return borc;
        }

        private void btnBorclarınToplamı_Click(object sender, EventArgs e)
        {
            txtBorcToplami.Text = Borclar(7).ToString();
        }

        private void btnTumAldiklarim_Click(object sender, EventArgs e)
        {
            txtTumAldiklarim.Text = Borclar(8).ToString();
        }

        private void btnTumOdemelerim_Click(object sender, EventArgs e)
        {
            txtTumOdemeleri.Text = Borclar(9).ToString();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("prc_Tedarikciler_TedarikciGetir", Tools.Baglanti);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                report.RegisterData(dt, "dt");
                report.Load(Application.StartupPath + "\\TedarikciRaporlari.FRX");
                report.Show();
                //report.Design();
            }  
          
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Tedarikciler t = new Tedarikciler();
                t.TedarikciId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                t.SirketAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                t.Yetkili = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                t.Telefon = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                t.WebSayfasi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                t.Adres = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                t.Email = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                t.Borcun = (decimal)dataGridView1.CurrentRow.Cells[7].Value;
                ToptanciDuzenle td = new ToptanciDuzenle(t)
                {
                    MdiParent = this.MdiParent
                };
                td.Show(); 
            }
            else MessageBox.Show("BİR TOPTANCI SEÇİNİZ","TOPTANCI",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Tedarikciler t = new Tedarikciler();
            t.SirketAdi = txtAra.Text;
            dataGridView1.DataSource= TedarikciORM.TedarikciAra(t);
            Tables.DataGridViewTedarikciler(dataGridView1);
        }

      
    }
}
