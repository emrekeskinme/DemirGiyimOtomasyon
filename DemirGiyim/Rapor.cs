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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        private void btnRaporla_Click(object sender, EventArgs e)
        {
            getir();
        }

        void getir()
        {
            string t1 = date1.Value.ToString("yyyy-MM-dd");
            string t2 = date2.Value.ToString("yyyy-MM-dd");

            SqlCommand kmt = new SqlCommand("Select Satis.sID, SatisDetay.BarkodNo, Urunler.UrunAdi, SatisDetay.UrunAdet, Satis.Tarih,  Satis.Tutar, SatisDetay.SatisYapan from Satis inner join SatisDetay on Satis.sID=SatisDetay.SatisID inner join Urunler on SatisDetay.BarkodNo=Urunler.barkodNo where Satis.Tarih Between '" + t1 + "'and'" + t2 + "' order by Satis.sID Desc", bag);
            bag.Open();
            SqlDataAdapter adpt=new SqlDataAdapter(kmt);
            DataTable tab = new DataTable();
            adpt.Fill(tab);
            dataGridView1.DataSource = tab;
            bag.Close();     
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            getir();
            ToplamUrun();
            ToplamSatilanUrun();
            KullaniciSayisi();
            ToplamTutar();
            MarkaSayisi();
            ToptanciSayisi();
            ToplamStok();
        }

        
        void ToplamUrun()
        {
            SqlCommand kmt = new SqlCommand("select COUNT(urunID) from Urunler", bag);
            bag.Open();
            int kayitSayisi = Convert.ToInt32(kmt.ExecuteScalar());
            bag.Close();
            lblToplamUrun.Text = kayitSayisi.ToString();
        }
        void ToplamSatilanUrun()
        {
            SqlCommand kmt = new SqlCommand("select SUM(UrunAdet) from SatisDetay", bag);
            bag.Open();
            int kayitSayisi = Convert.ToInt32(kmt.ExecuteScalar());
            bag.Close();
            lblToplamSatilanUrun.Text = kayitSayisi.ToString();
        }
        void KullaniciSayisi()
        {
            SqlCommand kmt = new SqlCommand("select COUNT(K_ID) from Kullanicilar", bag);
            bag.Open();
            int kayitSayisi = Convert.ToInt32(kmt.ExecuteScalar());
            bag.Close();
            lblKullaniciSayisi.Text = kayitSayisi.ToString();
        }
        void ToplamTutar()
        {
            SqlCommand kmt = new SqlCommand("select SUM(Tutar) from Satis", bag);
            bag.Open();
            double kayitSayisi = Convert.ToDouble(kmt.ExecuteScalar());
            bag.Close();
            lblTT.Text = kayitSayisi.ToString() + " TL";
        }
        void MarkaSayisi()
        {
            SqlCommand kmt = new SqlCommand("select COUNT(MarkaID) from Markalar", bag);
            bag.Open();
            double kayitSayisi = Convert.ToDouble(kmt.ExecuteScalar());
            bag.Close();
            lblMarkaSayisi.Text = kayitSayisi.ToString();
        }
        void ToptanciSayisi()
        {
            SqlCommand kmt = new SqlCommand("select COUNT(ToptanciID) from Toptancilar", bag);
            bag.Open();
            double kayitSayisi = Convert.ToDouble(kmt.ExecuteScalar());
            bag.Close();
            lblToptanciSayisi.Text = kayitSayisi.ToString();
        }
        void ToplamStok()
        {
            SqlCommand kmt = new SqlCommand("select SUM(Urun_StokAdet) from Urunler", bag);
            bag.Open();
            double kayitSayisi = Convert.ToDouble(kmt.ExecuteScalar());
            bag.Close();
            lblTStok.Text = kayitSayisi.ToString();
        }


        private void cbAramaSecenegi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAramaSecenegi.SelectedIndex == 0)
            {
                getir();
                cbAd.Items.Clear();
            }
            else if (cbAramaSecenegi.SelectedIndex == 1)
            {
                cbAd.Items.Clear();
                SqlCommand kmt = new SqlCommand("Select UrunAdi from Urunler", bag);
                bag.Open();
                SqlDataReader reader = kmt.ExecuteReader();
                while (reader.Read())
                {
                    cbAd.Items.Add(reader[0].ToString());
                }
                bag.Close();
                cbAd.SelectedIndex = 0;
            }
            else if (cbAramaSecenegi.SelectedIndex == 2)
            {
                cbAd.Items.Clear();
                SqlCommand kmt = new SqlCommand("Select K_AdSoyad from Kullanicilar", bag);
                bag.Open();
                SqlDataReader reader = kmt.ExecuteReader();
                while (reader.Read())
                {
                    cbAd.Items.Add(reader[0].ToString());
                }
                bag.Close();
                cbAd.SelectedIndex = 0;
            }
        }

        private void cbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAramaSecenegi.SelectedIndex == 1)
            {
                 string t1 = date1.Value.ToString("yyyy-MM-dd");
                 string t2 = date2.Value.ToString("yyyy-MM-dd");

                 SqlCommand kmt = new SqlCommand("Select Satis.sID, SatisDetay.BarkodNo, Urunler.UrunAdi, SatisDetay.UrunAdet, Satis.Tarih,  Satis.Tutar, SatisDetay.SatisYapan from Satis inner join SatisDetay on Satis.sID=SatisDetay.SatisID inner join Urunler on SatisDetay.BarkodNo=Urunler.barkodNo where Satis.Tarih Between '" + t1 + "'and'" + t2 + "' and Urunler.UrunAdi='" + cbAd.Text + "' order by Satis.sID Desc", bag);
                 bag.Open();
                 SqlDataAdapter adpt=new SqlDataAdapter(kmt);
                 DataTable tab = new DataTable();
                 adpt.Fill(tab);
                 dataGridView1.DataSource = tab;
                 bag.Close();
            }
            else if (cbAramaSecenegi.SelectedIndex == 2)
            {
                string t3 = date1.Value.ToString("yyyy-MM-dd");
                string t4 = date2.Value.ToString("yyyy-MM-dd");

                SqlCommand kmt2 = new SqlCommand("Select Satis.sID, SatisDetay.BarkodNo, Urunler.UrunAdi, SatisDetay.UrunAdet, Satis.Tarih,  Satis.Tutar, SatisDetay.SatisYapan from Satis inner join SatisDetay on Satis.sID=SatisDetay.SatisID inner join Urunler on SatisDetay.BarkodNo=Urunler.barkodNo inner join Kullanicilar on SatisDetay.SatisYapan=Kullanicilar.K_AdSoyad where Satis.Tarih Between '" + t3 + "'and'" + t4 + "' and Kullanicilar.K_AdSoyad='" + cbAd.Text + "' order by Satis.sID Desc", bag);
                bag.Open();
                SqlDataAdapter adpt2 = new SqlDataAdapter(kmt2);
                DataTable tab2 = new DataTable();
                adpt2.Fill(tab2);
                dataGridView1.DataSource = tab2;
                bag.Close();
            }
        }
    }
}
