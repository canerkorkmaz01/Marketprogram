using System;
using System.Drawing;
using System.Windows.Forms;

namespace Market_Programı
{
   public class Keyboard
    {

        public enum Klavye
        {
            A=1, B=2, C=3, Ç=4, D=5, E=6,F=7, G=8, Ğ=9, H=10, I=11, İ=12, J=13, K=14, L=15, M=16,
            N=17, O=18, Ö=19, P=20, R=21, S=22, Ş=23, T=24, U=25, Ü=26, V=27, Y=28, Z=29, W=30, X=31, Q=32
        }
     
        /// <summary>
        /// Dinamik Buton Oluşturma 
        /// </summary>
        /// <param name="f"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="text"></param>
        private void Butonlar(FlowLayoutPanel f, int w,int h,string text)
        {
            Button btn = new Button();
            btn.Height = h;
            btn.Width = w;
            btn.Text = text;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Font = new Font("Arial", 30, FontStyle.Italic);
            f.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        /// <summary>
        /// Butonların Click Event Tıkladıgımız Zamana Olması Gereken Olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Giris g = (Giris)Application.OpenForms["Giris"];

            Button btn = (sender as Button);

            if (btn.Text == "BOŞLUK")
            {
                g.txtSifre.Text += g.txtSifre.Text = " ";
            }
            else if (btn.Text == "<--- Sil")
            {
                g.txtSifre.Clear();
            }
            else if (btn.Text == "ENTER")
            {
                g.btnGiris_Click(null, null);
            }
            else
            {
                g.txtSifre.Text += g.txtSifre.Text = btn.Text;
            }
            
        }

        /// <summary>
        /// Klavyeden Basılan Tuşu Yakalama 
        /// </summary>
        /// <param name="f"></param>
        public void Keyboards(FlowLayoutPanel f)
        {
            #region Test Kodları Degerlendi
            //foreach (string item in Enum.GetNames(typeof(Klavye)))
            //{
            //    Butonlar(f, 60, 60, item);
            //} 

            //for (; i < 51; i++)
            //{
            //    if (i == 51) break;
            //     else if (i != 48) ///Sayılar Olacak
            //    {
            //        if (j != 10)
            //        {
            //            if (j != 10)
            //            {
            //                j++;
            //                Butonlar(f, 60, 60, j.ToString()); 
            //            }
            //        }
            //    }

            //} 
            #endregion
            object[] Karekter = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, "+", "-", "*", "/", ".", "," };
            foreach (string item in Enum.GetNames(typeof(Klavye)))
            {
                Butonlar(f, 50, 50, item);
            }
            foreach (object krk in Karekter)
            {
                Butonlar(f, 50, 50, krk.ToString());
            }
            Butonlar(f, 300, 50, "BOŞLUK");
            Butonlar(f, 50, 50, "");
            Butonlar(f, 300, 50, "<--- Sil");
            Butonlar(f, 50, 50, "");
            Butonlar(f, 300, 50, "ENTER");
        }

    }
}
