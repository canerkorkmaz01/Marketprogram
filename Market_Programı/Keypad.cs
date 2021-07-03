using ORM;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Market_Programı
{
    public class Keypad
    {
        public enum Letter
        {
            A = 1, B = 2, C = 3, Ç = 4, D = 5, E = 6, F = 7, G = 8, Ğ = 9, H = 10, I = 11, İ = 12, J = 13, K = 14, L = 15, M = 16,
            N = 17, O = 18, Ö = 19, P = 20, R = 21, S = 22, Ş = 23, T = 24, U = 25, Ü = 26, V = 27, Y = 28, Z = 29, W = 30, X = 31, Q = 32
        }

        /// <summary>
        /// Dinamik Buton Oluşturma 
        /// </summary>
        /// <param name="f"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="text"></param>
        private void Butonlar(FlowLayoutPanel f, int w, int h, string text)
        {
            Button btn = new Button();
            btn.Height = h;
            btn.Width = w;
            btn.Text = text;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Font = new Font("Arial", 40, FontStyle.Italic);
            f.Controls.Add(btn);
            btn.Click += Btn_Click;
        }
        private string ButonClick(object sender,TextBox t)
        {
            string text = string.Empty;
            Button btn = (sender as Button);
            if (btn.Text == "BOŞLUK")
            {
                 t.Text += t.Text = " ";
            }
            else if (btn.Text == "<--- Sil")
            {
                try
                {
                    t.Text = t.Text.Substring(0, t.Text.Length - 1);
                }
                catch (Exception ) { ; }
            }
            else
            {
              t.Text  = btn.Text;
            }
            return text= t.Text; 
        }

        /// <summary>
        /// Butonların Click Event Tıkladıgımız Zamana Olması Gereken Olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            Button btn = (sender as Button);
            if (Tools.Keypad ==1)
            {
                ManuelUrunArama mua = (ManuelUrunArama)Application.OpenForms["ManuelUrunArama"];
                mua.txtArama.Text += ButonClick(sender, t);
                if (btn.Text == "<--- Sil")
                {
                    try
                    {
                        mua.txtArama.Text = mua.txtArama.Text.Substring(0, mua.txtArama.Text.Length - 1);
                    }
                    catch (Exception) {; }
                }
            }
            else if(Tools.Keypad == 2)
            {
                MusteriListesi ms = (MusteriListesi)Application.OpenForms["MusteriListesi"];
                ms.txtMusteriAra.Text += ButonClick(sender,t);
                if (btn.Text == "<--- Sil")
                {
                    try
                    {
                        ms.txtMusteriAra.Text = ms.txtMusteriAra.Text.Substring(0, ms.txtMusteriAra.Text.Length - 1);
                    }
                    catch (Exception) {; }
                }
            }
           
        }

        /// <summary>
        /// Klavyeden Basılan Tuşu Yakalama 
        /// </summary>
        /// <param name="f"></param>
        public void Keyboards(FlowLayoutPanel f)
        {

            object[] Karekter = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, "+", "-", "*", "/", ".", "," };
            foreach (string item in Enum.GetNames(typeof(Letter)))
            {
                Butonlar(f, 60, 60, item);
            }
            foreach (object krk in Karekter)
            {
                Butonlar(f, 60, 60, krk.ToString());
            }
            Butonlar(f, 300, 60, "BOŞLUK");
            Butonlar(f, 60, 60, "");
            Butonlar(f, 300, 60, "<--- Sil");
            Butonlar(f, 60, 60, "");
        }
    }
}
