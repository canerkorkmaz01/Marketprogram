using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class HizliSatisKaldir : Form
    {
        public HizliSatisKaldir()
        {
            InitializeComponent();
        }

        private void cboHizliSatislar_Click(object sender, EventArgs e)
        {
            cboHizliSatislar.DataSource = HizliSatisORM.HizliSatisListele();
            cboHizliSatislar.ValueMember = "HizliSatisId";
            cboHizliSatislar.DisplayMember = "UrunAdi";
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHizliSatisKaldir_Click(object sender, EventArgs e)
        {
            Satis s = (Satis)Application.OpenForms["Satis"];
            int id =(int) cboHizliSatislar.SelectedValue;
            HizliSatisORM hsORM = new HizliSatisORM();
            hsORM.HizliSatisKaldir(id);
            s.FlowLayouyPanel1.Controls.Clear();
            s.HizliSatisButonlari(Tools.hizliSatisButon);
            this.Dispose();
        }
    }
}
