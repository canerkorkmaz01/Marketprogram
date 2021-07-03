using Microsoft.Office.Interop.Excel;
using ORM;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class Servis : Form
    {
   
        public Servis()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            ExcelKapat();
            this.Dispose();
        }

        private void ExcelKapat()
        {
            foreach (Process excelDoyalari in Process.GetProcessesByName("EXCEL"))
            {
                excelDoyalari.Kill();
            }
        }

        private void btnNeredenBasla_Click(object sender, EventArgs e)
        {
            NeredenBaslamaliyim nb = new NeredenBaslamaliyim
            {
               MdiParent=this.MdiParent
            };
            nb.Show();
        }

        private void btnUrunListesiniAktar_Click(object sender, EventArgs e)
        {
                     
            dataGridView1.DataSource = UrunlerORM.UrunListesiniExcelAktar();
            Tables.DataGridViewExcel(dataGridView1);

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int baslamakolonu = 1;
            int baslamasatiri = 2;
            excel.Cells[1, 2].value = "DOKUMANTİK MARKET PROGRAMI ÜRÜN LİSTESİ";
            excel.Cells[1, 2].Font.Size = 12;
            excel.Cells[1, 2].Font.Color = Color.Blue;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[baslamasatiri, baslamakolonu + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            baslamasatiri++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excel.Cells[2, i + 1].Font.Size = 12;
                    excel.Cells[2, i + 1].Font.Color = Color.Red;
                    Range myRange = (Range)sheet1.Cells[baslamasatiri + i, baslamasatiri + j-2];
                    myRange.Value = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Style.HorizontalAlignment =HorizontalAlignment.Center;
                    sheet1.PageSetup.PrintGridlines = true;
                    //myRange.Rows(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    //myRange.Row[2].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    myRange.EntireColumn.AutoFit();
                    myRange.NumberFormat = "0";
                    myRange.Cells[j,3].NumberFormat = "0,00₺";
                    myRange.Cells[j,4].NumberFormat = "0,00₺";
                }
            }

            //workbook.Application.Quit();
            //sheet1.Application.Quit();
            //excel.Application.Quit();
            //GC.Collect();
          
        }

        private void Servis_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExcelKapat();
            this.Dispose();
        }

        private void btnMusteriListesiniAktar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UrunlerORM.MusteriListesiniExcelAktar();
            Tables.DataGridViewExcelMusteri(dataGridView1);

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int baslamakolonu = 1;
            int baslamasatiri = 2;
            excel.Cells[1, 2].value = "MÜŞTERİ LİSTESİ";
            excel.Cells[1, 2].Font.Size = 12;
            excel.Cells[1, 2].Font.Color = Color.Blue;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[baslamasatiri, baslamakolonu + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            baslamasatiri++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excel.Cells[2, i + 1].Font.Size = 12;
                    excel.Cells[2, i + 1].Font.Color = Color.Red;
                    Range myRange = (Range)sheet1.Cells[baslamasatiri + i, baslamasatiri + j - 2];
                    myRange.Value = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Style.HorizontalAlignment = HorizontalAlignment.Center;
                    sheet1.PageSetup.PrintGridlines = true;
                    myRange.EntireColumn.AutoFit();
                    myRange.NumberFormat = "0";
                    myRange.Cells[j, 3].NumberFormat = "0,00₺";
                    myRange.Cells[j, 4].NumberFormat = "0,00₺";
                    myRange.Cells[j, 5].NumberFormat = "0,00₺";
                    myRange.Cells[j, 6].NumberFormat = "gg.aa.yyyy ss:dd";
                }
            }
        }

        private void btnToptanciListesiniAktar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UrunlerORM.ToptanciListesiniExcelAktar();
            Tables.DataGridViewExcelTedarikci(dataGridView1);

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int baslamakolonu = 1;
            int baslamasatiri = 2;
            excel.Cells[1, 2].value = "TOPTANCI LİSTESİ";
            excel.Cells[1, 2].Font.Size = 12;
            excel.Cells[1, 2].Font.Color = Color.Blue;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[baslamasatiri, baslamakolonu + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            baslamasatiri++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excel.Cells[2, i + 1].Font.Size = 12;
                    excel.Cells[2, i + 1].Font.Color = Color.Red;
                    Range myRange = (Range)sheet1.Cells[baslamasatiri + i, baslamasatiri + j - 2];
                    myRange.Value = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Style.HorizontalAlignment = HorizontalAlignment.Center;
                    sheet1.PageSetup.PrintGridlines = true;
                    myRange.EntireColumn.AutoFit();
                    myRange.NumberFormat = "0";
                    myRange.Cells[j, 4].NumberFormat = "0,00₺";
                    myRange.Cells[j, 5].NumberFormat = "0,00₺";
                    myRange.Cells[j, 6].NumberFormat = "0,00₺";
                    myRange.Cells[j, 7].NumberFormat = "gg.aa.yyyy ss:dd";
                }
            }
        }

        private void btnYardım_Click(object sender, EventArgs e)
        {
            Yardım y = new Yardım
            {
                MdiParent = this.MdiParent
            }; y.Show();
        }

        private void btnLisanslama_Click(object sender, EventArgs e)
        {
            Lisanslama l = new Lisanslama
            {
              MdiParent = this.MdiParent
            }; l.Show();
        }

        private void Servis_Load(object sender, EventArgs e)
        {

        }
    }
}
