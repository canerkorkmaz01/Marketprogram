using Entity;
using ORM;
using System;
using System.Drawing;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class StokUrunleri : Form
    {
        public StokUrunleri()
        {
            InitializeComponent();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txtAra.Text;
            dataGridView1.DataSource = UrunlerORM.AdGoreUrunArama(u);
            Tables.DataGridViewStokUrunleri(dataGridView1);
        }

        private void StokUrunleri_Load(object sender, EventArgs e)
        {
            
            Urunler u = new Urunler();
            dataGridView1.DataSource = UrunlerORM.UrunListesi();
            Tables.DataGridViewStokUrunleri(dataGridView1);
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StokGir sg = (StokGir)Application.OpenForms["StokGir"];
            sg.btnTamam.Enabled = true;
            sg.txtUrunAdi.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sg.txtBarkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sg.txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sg.txtStok.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sg.txtSatisFiyati.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            sg.txtAlisFiyati.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            sg.txtUrunAdeti.BackColor = Color.Red;
            this.Dispose();
        }
    }
}
