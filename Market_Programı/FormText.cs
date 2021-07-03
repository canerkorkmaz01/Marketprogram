using System;
using System.Drawing;
using System.Windows.Forms;

namespace Market_Programı
{
    public class FormText
    {
        /// <summary>
        /// Formun Açılışında Veritabanından Gelen Bilgiyi Formun Text
        /// Ortalamak İçin Kullanılır
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="frmAdi"></param>
        public static void FormTextPozisyonu(Form frm, string frmAdi)
        {
            Graphics g = frm.CreateGraphics();
            Double Baslangic = (frm.Width / 2) - (g.MeasureString(frm.Text.Trim(), frm.Font).Width / 2) - 7;
            Double FormGenisligi = g.MeasureString(" ", frm.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + FormGenisligi) < Baslangic)
            {
                tmp += " ";
                tmpWidth += FormGenisligi;
            }
            frm.Text = frmAdi + tmp + frm.Text.Trim() + "***"+ "DENEME SÜRÜMÜ"+ "  " + DateTime.Now + "***";

        }
    }
}
