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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        DataTable tablo = new DataTable();

        void listele()
        {
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler_Kategori", bag);
            tablo.Clear();
            bag.Open();
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand Sil = new SqlCommand("Delete from Urunler_Kategori Where UrunKatID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Sil.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Silinmiştir.");
            listele();
            ClearAll(this.panel1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKatAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler_Kategori Where UrunKatAdi Like '%" + txtAra.Text + "%'", bag);
            tablo.Clear();
            bag.Open();
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand Guncelle = new SqlCommand("UPDATE Urunler_Kategori SET UrunKatAdi='" + txtKatAdi.Text + "' WHERE UrunKatID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Guncelle.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Başarıyla Güncellenmiştir.");
            ClearAll(this.panel1);
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert INTO Urunler_Kategori (UrunKatAdi) VALUES ('" + txtKatAdi.Text + "')", bag);
            bag.Open();
            ekle.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Ekleme İşlemi Başarı İle Gerçekleştirilmiştir.");
            listele();
            ClearAll(this.panel1);
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            UrunGirisi urun = new UrunGirisi();
            urun.Show();
            this.Hide();
        }
    }
}
