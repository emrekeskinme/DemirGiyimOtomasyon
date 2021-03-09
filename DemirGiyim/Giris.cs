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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();

        DataTable tablo = new DataTable();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Kullanicilar where K_KullaniciAdi = @KAdi and K_Sifre = @KParola", bag);
                cmd.Parameters.AddWithValue("@KAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@KParola", txtSifre.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                            this.Hide();
                            Kullanicilar.AdSoyad = rd["K_AdSoyad"].ToString();
                            AnaForm ana = new AnaForm();
                            //((Label)ana.Controls["lblKullanici"]).Text = Kullanicilar.AdSoyad;
                            MessageBox.Show("Hoşgeldiniz " + Kullanicilar.AdSoyad);
                            ana.ShowDialog();
                    }
                    
                }
                else
                {
                    rd.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminGirisi_Click(object sender, EventArgs e)
        {
            AdminGirisi admingirisi = new AdminGirisi();
            admingirisi.Show();
            this.Hide();
        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //void CreateDB()
        //{
        //    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated security=true");
        //    //Aşağıdaki sorgu SQLEXPRESS üzerinde bizim veritabanımızın (SETUPPROJESI) olup olmadığını kontrol ediyor ve eğer yoksa böyle bir veritabanı oluşturuyor.
        //    SqlCommand cmd = new SqlCommand("if not exists(select * from sys.databases where name = 'DemirGiyim') begin CREATE DATABASE DemirGiyim ON PRIMARY (NAME = DemirGiyim_Data,FILENAME = 'D:\\DemirGiyim.mdf',SIZE = 3MB,MAXSIZE = 10MB, FILEGROWTH = 10%) LOG ON (NAME = DemirGiyim_Log,FILENAME = 'D:\\DemirGiyim.ldf',SIZE = 1MB,MAXSIZE = 5MB,FILEGROWTH = 10%) end");
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    //Şimdi de veritabanımız içerisinde tablomuzun olup olmadığına bakalım ve eğer tablomuz yoksa tablomuzu oluşturalım ve verilerimizi atalım.
        //    con.ConnectionString = "Data Source=.;Initial Catalog=DemirGiyim;Integrated security=true";
        //    //Aşağıdaki sorgu Kullanicilar tablosunun olup olmadığına bakmakta ve eğer yoksa oluşturarak içerisine kayıtları eklemektedir.
        //    cmd.CommandText = "if not exists(select * from sys.tables where name = 'Kullanicilar') begin create table Kullanicilar(K_ID int identity(1,1) primary key,K_AdSoyad varchar(150),K_KullaniciAdi varchar(150),K_Sifre varchar(150), K_Adminlik bit) insert into Kullanicilar (K_AdSoyad,K_KullaniciAdi,K_Sifre,K_Adminlik) values(N'Ali Keskin', N'Admin', N'123', 1) end";
        //    cmd.CommandText = "";
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

        //private void Giris_Activated(object sender, EventArgs e)
        //{
        //    CreateDB();
        //}
    }
}
