using Entity;
using Microsoft.Win32;
using ORM;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void giris()
        {
            cboKullanicAdi.DataSource = PersonellerORM.KullaniciAdlari();
            cboKullanicAdi.DisplayMember = "KAdi";
            cboKullanicAdi.ValueMember = "PersonelId";
        }
        private void AcilisBilgileriKontrol()
        {
            VeritabaniOlustur db = new VeritabaniOlustur();
            int gun = 0;
            TimeSpan ts = new TimeSpan();
            DateTime d1, d2;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ads", true);
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ads");
            if (key == null)
            {
                reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ads", true);
                reg.SetValue("Day", Sifreleme.Encrypt("30"));
                reg.SetValue("True", Sifreleme.Encrypt("1"));
                reg.SetValue("Date", Sifreleme.Encrypt(DateTime.Now.ToString()));
                Thread t = new Thread(new ThreadStart(db.VeritabanıKurulumu));
                t.Start();
             
                giris();
                if (File.Exists(Application.StartupPath + @"\script.sql"))
                    {
                        File.Delete(Application.StartupPath + @"\script.sql");
                    }
            }
            else
            {
                if(Sifreleme.Decrypt(reg.GetValue("True").ToString()) == "1")
                {
                    d1 = Convert.ToDateTime(Sifreleme.Decrypt(reg.GetValue("Date").ToString()));
                    d2 = DateTime.Now;
                    ts = d2 - d1;
                    gun =30 - ts.Days;
                    reg.SetValue("Day", Sifreleme.Encrypt(gun.ToString()));
                    if ( ts.Days == 30)
                    {
                        reg.SetValue("Day", Sifreleme.Encrypt("0"));
                        reg.SetValue("True", Sifreleme.Encrypt("0"));
                        if (Sifreleme.Decrypt(reg.GetValue("Day").ToString()) == "0")
                        {
                            reg.SetValue("True", Sifreleme.Encrypt("0"));
                            MessageBox.Show("LİSANS SÜRENİZ BİTMİŞTİR YÖNETİCİNİZLE GÖRÜŞÜNÜZ","LİSANS SÜRESİ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            Application.Exit();
                        }
                    }
                 
                    else giris();
                 }
                else if (Sifreleme.Decrypt(reg.GetValue("True").ToString()) == "0")
                {
                    MessageBox.Show("LİSANS SÜRENİZ BİTMİŞTİR YÖNETİCİNİZLE GÖRÜŞÜNÜZ", "LİSANS SÜRESİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                else if (Sifreleme.Decrypt(reg.GetValue("True").ToString()) == "2")
                {
                    giris();
                }
            }

         
            reg.Close();
            //key.Close();
        }
        private void lblKlavye_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible == false)
            {
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.Controls.Clear();
                Keyboard k = new Keyboard();
                k.Keyboards(flowLayoutPanel1);
                
            }
            else flowLayoutPanel1.Visible = false;
        }
        public void btnGiris_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            PersonellerORM pORM = new PersonellerORM();
            p.KAdi = cboKullanicAdi.Text;
            p.Sifre = txtSifre.Text;
            pORM.PersonelGiris(p);
            bool dönüs = PersonellerORM.Dönüs;
            if (dönüs)
            {
                Tools.PersonelID = (int)cboKullanicAdi.SelectedValue;
                MarketOtomasyonu mo = new MarketOtomasyonu();
                mo.Show();
                this.Hide(); 
            }

        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Giris_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            AcilisBilgileriKontrol();
        }

    }
}
