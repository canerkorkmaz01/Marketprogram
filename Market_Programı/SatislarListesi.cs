using Entity;
using ORM;
using System;
using System.Windows.Forms;

namespace Market_Programı
{
    public class SatislarListesi
    {
        /// <summary>
        /// Satislar Metodu Veresiye Müşterileri Satislar Tablosuna Yazar
        /// </summary>
        /// <param name="id"></param>
        public void Satislar(int id)
        {
            SatisDetaylari sd = new SatisDetaylari();
            Satislar satislar = new Satislar();

            Satis s = (Satis)Application.OpenForms["Satis"];
            for (int i = 0; i < s.dataGridView1.RowCount; i++)
            {
                sd.BarkodNo = s.dataGridView1.Rows[i].Cells[0].Value.ToString();
                satislar.SatisDetayID = (int)SatisDetayORM.SatisDetayId(sd); 
                satislar.MusteriID = id;
                satislar.PersonelID = Tools.PersonelID;
                satislar.SatisTarih = DateTime.Now;
                if (UrunlerORM.StokMiktariGetir(sd) != 0)
                {
                    SatisORM.SatisEkle(satislar);
                }
                
            }
        }
    }
}
