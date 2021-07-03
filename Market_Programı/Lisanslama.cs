using License;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Lisanslama : Form
    {
        public Lisanslama()
        {
            InitializeComponent();
        }
        private void Lisanslama_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ads");
            if (Sifreleme.Decrypt(reg.GetValue("True").ToString()) == "2")
                panel1.Enabled = false;
            reg.Close();
        }
        private void btnAktivasyon_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\ads", true);
            KeyManager km = new KeyManager(txtAnahtarKodu.Text);
            string productkey = txtLisansKodu.Text;
            if (txtSirketAdi.Text == string.Empty)
            {
                MessageBox.Show("Sirket Adı Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ComputerInfo.GetComputerId() == txtAnahtarKodu.Text)
                {
                    if (km.ValidKey(ref productkey))
                    {
                        KeyValuesClass kv = new KeyValuesClass();
                        if (km.DisassembleKey(productkey, ref kv))
                        {
                            LicenseInfo lic = new LicenseInfo();
                            lic.ProductKey = productkey;
                            lic.FullName = txtSirketAdi.Text;
                           
                            if (ComputerInfo.GetComputerId() == txtAnahtarKodu.Text)
                            {
                                km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                                MessageBox.Show("Lisanslama İşlemi Başarılı", "Lisanslama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reg.SetValue("FULL", Sifreleme.Encrypt(txtLisansKodu.Text));
                                reg.SetValue("Day", Sifreleme.Encrypt("0"));
                                reg.SetValue("True", Sifreleme.Encrypt("2"));

                                reg.Close();
                                this.Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Hatalı Lisans Anahtarı", "Lisanslama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Hatalı Lisans Anahtarı", "Lisanslama", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reg.Close();


        }

        private void btnKpat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
