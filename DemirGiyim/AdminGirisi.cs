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
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();

        DataTable tablo = new DataTable();
        AnaForm ana = new AnaForm();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Kullanicilar where K_KullaniciAdi = @KAdi and K_Sifre = @KParola and K_Adminlik = @Durum", bag);
                cmd.Parameters.AddWithValue("@KAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@KParola", txtSifre.Text);
                cmd.Parameters.AddWithValue("@Durum", 1);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        AdminPaneli giris = new AdminPaneli();
                        giris.Show();
                        this.Hide();
                        ana.Close();
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
        private void btnKullaniciGirisi_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
