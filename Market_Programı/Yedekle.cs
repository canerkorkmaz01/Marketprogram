using ORM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class Yedekle : Form
    {
        public Yedekle()
        {
            InitializeComponent();
        }

        private void btnYoluKaydet_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupYolu.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnYedekEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRestoreYolu.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = Tools.Baglanti.Database.ToString();
            try
            {

                if (txtBackupYolu.Text == string.Empty)
                {
                    MessageBox.Show("Yedek Alınacak Veritabanı Yolu Seçiniz", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtBackupYolu.Text + "\\" + "MARKET" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, Tools.Baglanti))
                    {
                        if (Tools.Baglanti.State == ConnectionState.Closed)
                        {
                            Tools.Baglanti.Open();
                        }
                        command.ExecuteNonQuery();
                        Tools.Baglanti.Close();
                        MessageBox.Show("Veritabanı Başarıyla Yedeği Alındı", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRestore.Enabled = false;
                    }
                }

            }
            catch (Exception) { }
            Application.Exit();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = Tools.Baglanti.Database.ToString();
            if (Tools.Baglanti.State != ConnectionState.Open)
            {
                Tools.Baglanti.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, Tools.Baglanti);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestoreYolu.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, Tools.Baglanti);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, Tools.Baglanti);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Veritabanı Başarıyla Yüklendi");
                Tools.Baglanti.Close();

            }
            catch (Exception) { }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
   
