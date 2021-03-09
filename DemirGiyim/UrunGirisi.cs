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
    public partial class UrunGirisi : Form
    {
        
        public UrunGirisi()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();

        DataTable tablo = new DataTable();

        void KategoriListele()
        {
            cbKategori.Items.Clear();
            SqlDataReader oku;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Urunler_Kategori";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cbKategori.Items.Add(oku[1].ToString());
            }
            bag.Close();
        }
        void ToptanciListele()
        {
            cbToptanci.Items.Clear();
            SqlDataReader oku;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Toptancilar";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cbToptanci.Items.Add(oku[1].ToString());
            }
            bag.Close();
        }
        void CinsiyetListele()
        {
            cbCinsiyet.Items.Clear();
            SqlDataReader oku;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Cinsiyetler";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cbCinsiyet.Items.Add(oku[1].ToString());
            }
            bag.Close();
        }
        void MarkaListele()
        {
            cbMarka.Items.Clear();
            SqlDataReader oku;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Markalar";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cbMarka.Items.Add(oku[1].ToString());
            }
            bag.Close();
        }
        private void UrunGirisi_Load(object sender, EventArgs e)
        {
            KategoriListele();
            ToptanciListele();
            MarkaListele();
            CinsiyetListele();

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AnaForm Anaform1 = new AnaForm();
            Anaform1.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "" || txtUrunAdi.Text == "" || cbKategori.Text == "" || txtSatisFiyat.Text == "")
            {
                MessageBox.Show("Girilmesi zorunlu alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand ekle = new SqlCommand("INSERT INTO Urunler (barkodNo,UrunAdi,UrunAciklama,UrunKategori,AlisFiyat,SatisFiyat,KDVOrani,Urun_StokAdet,U_Toptanci,UrunCinsiyet,UrunMarka,UrunBeden,UrunRenk) VALUES ('" + txtBarkodNo.Text + "','" + txtUrunAdi.Text + "','" + txtAciklama.Text + "','" + cbKategori.Text + "','" + txtAlisFiyat.Text + "','" + txtSatisFiyat.Text + "','" + txtKDV.Text + "','" + txtStok.Text + "','" + cbToptanci.Text + "','" + cbCinsiyet.Text + "','" + cbMarka.Text + "','" + cbBeden.Text + "','" + txtRenk.Text + "')", bag);
                bag.Open();
                ekle.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("Ekleme İşlemi Başarı İle Gerçekleştirilmiştir.");
                ClearAll(this.panel1);
            }
            
        }

        private void ClearAll(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)
                {
                    ClearAll(c);
                }
            }
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            Stok stokGor = new Stok();
            stokGor.Show();
            this.Hide();
        }

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            Kategoriler kat = new Kategoriler();
            kat.Show();
            this.Hide();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Markalar marka = new Markalar();
            marka.Show();
            this.Hide();
        }

    }
}
