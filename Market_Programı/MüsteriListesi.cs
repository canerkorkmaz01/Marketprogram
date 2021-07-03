using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }
      
        private void SatisDetayEkle()
        {
            Satis s = (Satis)Application.OpenForms["Satis"];
            SatisDetayORM sdORM = new SatisDetayORM();
            SatisDetaylari sd = new SatisDetaylari();
            if (s.dataGridView1.RowCount != 0)
            {
                for (int i = 0; i < s.dataGridView1.RowCount; i++)
                {
                    sd.İndirim = Convert.ToDecimal(s.txtİskonto.Text);
                    if (i == 1) sd.İndirim = 0;
                    sd.BarkodNo = s.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    sd.UrunAdi = s.dataGridView1.Rows[i].Cells[1].Value.ToString();
                    sd.BirimFiyat = Convert.ToDecimal(s.dataGridView1.Rows[i].Cells[2].Value);
                    sd.Miktar = Convert.ToInt32(s.dataGridView1.Rows[i].Cells[3].Value);
                    sd.ToplamTutar = Convert.ToDecimal(s.dataGridView1.Rows[i].Cells[4].Value);
                    sd.SatisTürü = s.cboSatisTuru.Text;
                    sd.Tarih = DateTime.Now;
                    if (UrunlerORM.StokMiktariGetir(sd) != 0)
                    {
                        if (UrunlerORM.StokMiktariGetir(sd) != 0)
                        {
                            sdORM.SatisDetaylariEkle(sd);
                            //UrunlerORM.StokAzalat(sd); 
                        }
                        //-------------------------------------------------------------------
                        SatislarListesi sl = new SatislarListesi();
                        MusterilerORM mORM = new MusterilerORM();
                        Satis satis = (Satis)Application.OpenForms["Satis"];
                        DialogResult result = MessageBox.Show("SEÇİLEN MÜŞTERİNİN HESABINA EKLENSİNMİ" + " " + satis.Toplam() + " " + "TL", "CARİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        decimal toplam = satis.Toplam() + MusterilerORM.MusterilerBorcGetir(id);
                        if (result == DialogResult.OK)
                        {
                            mORM.MusteriBorcEkle(id, toplam);
                            dataGridView1.DataSource = MusterilerORM.MusterileriGetir();
                            Tables.DataGridViewMusteriListele(dataGridView1);
                            satis.lblPesinMusteri.Text = MusterilerORM.MusterilerBorcBilgisi(id).Rows[0]["Adi"].ToString();
                            satis.lblMusteriBorcu.Text = MusterilerORM.MusterilerBorcBilgisi(id).Rows[0]["Borc"].ToString();
                            satis.lblMusteriLimit.Text = MusterilerORM.MusterilerBorcBilgisi(id).Rows[0]["Limit"].ToString();
                            sl.Satislar(id);
                        }
                        MessageBox.Show("BORÇ EKLENDİ", "BORÇ EKLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UrunlerORM.dt.Clear();
                        this.Dispose();
                    }
                    else { }
                }
            }
            //if (UrunlerORM.StokMiktariGetir(sd) == 0) MessageBox.Show(UrunlerORM.StokUrunAdi(sd).Rows[0]["UrunAdi"].ToString() + " " + "Stokta Bulunmamaktadır...");
            //UrunlerORM.dt.Clear();
            //s.lblToplam.Text = "0";
            s.SatışYap();
            
        }
        private void MüsteriListesi_Load(object sender, EventArgs e)
        {
            Tools.Keypad = 2;
            flowLayoutPanel1.Controls.Clear();
            Keypad k = new Keypad();
            k.Keyboards(flowLayoutPanel1);
            dataGridView1.DataSource= MusterilerORM.MusterileriGetir();
            Tables.DataGridViewMusteriListele(dataGridView1);
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.Adi = txtMusteriAra.Text;
            dataGridView1.DataSource = MusterilerORM.MusteriAra(m);
            Tables.DataGridViewMusteriListele(dataGridView1);
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            SatisDetayEkle();
        }
    }
}
