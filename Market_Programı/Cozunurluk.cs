using System.Drawing;
using System.Windows.Forms;

namespace Market_Programı
{
    public class Cozunurluk
    {
        public int Width { get; set; } = 1440;
        public int Height { get; set; } = 900;
        public void Boyut(Form frm)
        {
            Rectangle ClientCoz = new Rectangle();
            ClientCoz = Screen.GetBounds(ClientCoz);
            float WidthOran = ((float)ClientCoz.Width / (float)Width);
            float HeightOran = ((float)ClientCoz.Height / (float)Height);
            frm.Scale(WidthOran, HeightOran);
        }
    }
}
