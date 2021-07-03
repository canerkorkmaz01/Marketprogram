using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public partial class KategoriKaldir : Form
    {
        public KategoriKaldir()
        {
            InitializeComponent();
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboKategoriler_Click(object sender, EventArgs e)
        {
            cboKategoriler.ValueMember = "HizliKateogriId";
            cboKategoriler.DisplayMember = "HizliBaslik";
            cboKategoriler.DataSource = HizliKategoriORM.HizliKategoriler();
        }

        private void btnKategoriKaldir_Click(object sender, EventArgs e)
        {
            Satis s = (Satis)Application.OpenForms["Satis"];
            int id = Convert.ToInt32(cboKategoriler.SelectedValue);
            HizliKategoriORM hkORM = new HizliKategoriORM();
            hkORM.KategoriKaldir(id);
            s.HizliKategoriler();
            this.Dispose();
        }
    }
}
