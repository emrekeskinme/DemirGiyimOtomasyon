using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemirGiyim
{
    public partial class FaturaYazdir : Form
    {
        public FaturaYazdir()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");

        public int SatirSayisi = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FaturaOlustur f = (FaturaOlustur)Application.OpenForms["FaturaOlustur"];

            try
            {
                //ÇİZİM BAŞLANGICI
                Font myFont = new Font("Calibri", 10); //font oluşturduk
                SolidBrush sbrush = new SolidBrush(Color.Black);//fırça oluşturduk
                Pen myPen = new Pen(Color.Black); //kalem oluşturduk
                Pen myPen2 = new Pen(Color.White, 100); 
                SolidBrush sbrush2 = new SolidBrush(Color.Red);
                SolidBrush sbrush3 = new SolidBrush(Color.DodgerBlue);

                e.Graphics.DrawString("Düzenlenme Tarihi ve Saati: " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString(), myFont, sbrush, 50, 25);
                e.Graphics.DrawLine(myPen, 50, 45, 770, 45); // Çizgi çizdik... 1. Kalem, 2. X, 3. Y Koordinatı, 4. Uzunluk, 5. BitişX

                myFont = new Font("Calibri", 17, FontStyle.Bold);//Fatura başlığı yazacağımız için fontu kalın yaptık ve puntoyu büyütüp 15 yaptık.
                e.Graphics.DrawString("Demir Giyim Fatura", myFont, sbrush3, 315, 57);
                e.Graphics.DrawLine(myPen, 50, 95, 770, 95); //çizgi çizdik.

                myFont = new Font("Calibri", 10, FontStyle.Bold); //Detay başlığını yazacağımız için fontu kalın yapıp puntoyu 10 yaptık.              
                e.Graphics.DrawString("Barkod No", myFont, sbrush, 70, 110); //Detay başlığı
                e.Graphics.DrawString("Ürün Adı", myFont, sbrush, 170, 110); //Detay başlığı
                e.Graphics.DrawString("Fiyat", myFont, sbrush, 400, 110); // Detay başlığı
                e.Graphics.DrawString("Adet", myFont, sbrush, 450, 110); //Detay başlığı
                e.Graphics.DrawString("Toplam Fiyat", myFont, sbrush, 510, 110);//Detay başlığı
                e.Graphics.DrawString("Toplam Tutar", myFont, sbrush2, 670, 110);//Detay başlığı
                e.Graphics.DrawLine(myPen, 50, 140, 770, 140); //Çizgi çizdik.

                int y = 150; //y koordinatının yerini belirledik.(Verilerin yazılmaya başlanacağı yer)

                myFont = new Font("Calibri", 10); //fontu 10 yaptık.

                int i = 0;//satır sayısı için değişken tanımladık.
                while (i <= f.dataGridView1.Rows.Count)//döngüyü son satırda sonlandıracağız.
                {
                    e.Graphics.DrawString(f.dataGridView1[0, i].Value.ToString(), myFont, sbrush, 90, y);//1.sütun
                    e.Graphics.DrawString(f.dataGridView1[1, i].Value.ToString(), myFont, sbrush, 170, y);//2.sütun
                    e.Graphics.DrawString(f.dataGridView1[2, i].Value.ToString(), myFont, sbrush, 400, y);//3.sütun
                    e.Graphics.DrawString(f.dataGridView1[3, i].Value.ToString(), myFont, sbrush, 460, y);//4.sütun
                    e.Graphics.DrawString(f.dataGridView1[4, i].Value.ToString(), myFont, sbrush, 530, y);//5.sütun
                    e.Graphics.DrawString(f.dataGridView1[5, i].Value.ToString(), myFont, sbrush2, 690, y);//6.sütun
                    e.Graphics.DrawLine(myPen2, 710, 170, 710, 1200);
                    y += 20; //y koordinatını arttırdık.
                    i += 1; //satır sayısını arttırdık

                    //yeni sayfaya geçme kontrolü
                    if (y > 1000)
                    {
                        e.Graphics.DrawString("(Devamı -->)", myFont, sbrush, 700, y + 50);
                        y = 50;
                        break; //burada yazdırma sınırına ulaştığımız için while döngüsünden çıkıyoruz
                        //çıktığımızda while baştan başlıyor i değişkeni değer almaya devam ediyor
                        //yazdırma yeni sayfada başlamış oluyor
                    }
                }
                //çoklu sayfa kontrolü
                if (i < SatirSayisi)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    i = 0;
                }
                StringFormat myStringFormat = new StringFormat();
                myStringFormat.Alignment = StringAlignment.Far;
            }
            catch
            {
            }
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            SqlCommand kmt = new SqlCommand("Delete from GeciciFatura", bag);
            bag.Open();
            kmt.ExecuteNonQuery();
            bag.Close();
            Satis ac = new Satis();
            ac.Show();
            this.Hide();
        }
    }
}
