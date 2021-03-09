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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        DataTable tablo = new DataTable();

        void listele()
        {
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from Kullanicilar", bag);
            tablo.Clear();
            bag.Open();
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDurum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert INTO Kullanicilar (K_AdSoyad,K_KullaniciAdi,K_Sifre,K_Adminlik) VALUES ('" + txtAdSoyad.Text + "','" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "','" + txtDurum.Text + "')", bag);
            bag.Open();
            ekle.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Ekleme İşlemi Başarı İle Gerçekleştirilmiştir.");
            listele();
            ClearAll(this.panel1);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand Guncelle = new SqlCommand("UPDATE Kullanicilar SET K_AdSoyad='" + txtAdSoyad.Text + "',K_KullaniciAdi='" + txtKullaniciAdi.Text + "',K_Sifre='" + txtSifre.Text + "',K_Adminlik='" + txtDurum.Text + "' WHERE K_ID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Guncelle.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Başarıyla Güncellenmiştir.");
            ClearAll(this.panel1);
            listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand Sil = new SqlCommand("Delete from Kullanicilar Where K_ID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Sil.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Silinmiştir.");
            listele();
            ClearAll(this.panel1);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearAll(this.panel1);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from Kullanicilar Where K_AdSoyad Like '%" + txtAra.Text + "%'", bag);
            tablo.Clear();
            bag.Open();
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapor rapolama = new Rapor();
            rapolama.Show();
        }
    }
}
