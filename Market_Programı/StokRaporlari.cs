using ORM;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Market_Programı
{
    public partial class StokRaporlari : Form
    {
        public StokRaporlari()
        {
            InitializeComponent();
        }

        private void StokRaporlari_Load(object sender, EventArgs e)
        {
         
            txtUrunMaliyeti.Text = StokBilgisiORM.StokUrunMaliyeti().Rows[0]["AlisToplam"].ToString();
            txtStokUrunSatisTutari.Text = StokBilgisiORM.StokUrunSatis().Rows[0]["SatisToplam"].ToString();
            txtSatisKaznamasıGerekenTutar.Text = StokBilgisiORM.StokSatisKarRapor().Rows[0]["KarToplam"].ToString();
            txtUrunCesidi.Text = StokBilgisiORM.StokToplamUrunRapor().Rows[0]["ToplamUrun"].ToString();
        }
        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            string[] data = { "STOKTAKİ ÜRÜNLERİ MALİYETİ", "STOKTAKİ ÜRÜNLERİN SATIŞ TUTARI", "SATIŞLARDAN KAZANMAN GEREKEN TUTAR", "ÜRÜN ÇEŞİDİNİZ" };
            int u = 3;
            int j = 5;
            int i = 4;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            excel.Workbooks.Add();
            excel.Worksheets[1].Activate();
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    excel.Cells[i, 1].value = "STOK RAPORU";
                    excel.Cells[i, 2].value = DateTime.Now;
                    excel.Cells[i, 1].Font.Size = 12;
                    excel.Cells[i, 1].Font.Color = Color.Red;
                    excel.Cells[i+1, 1].Font.Size = 12;
                    excel.Cells[i+1, 1].Font.Color = Color.Red;
                    excel.Cells[i + 1, 1].value = data[u];
                    excel.Cells[j--, 2].value = ctrl.Text;
                    excel.Columns[j].AutoFit();
                    i--;
                    u--;
                }
               
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
