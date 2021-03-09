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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();

        DataTable tablo = new DataTable();
        void listele()
        {
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler", bag);
            tablo.Clear();
            bag.Open();
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            KategoriListele();
            MarkaListele();
            CinsiyetListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AnaForm Anaform1 = new AnaForm();
            Anaform1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbKategori.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAlisFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSatisFiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtKDV.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbCinsiyet.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cbMarka.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cbBeden.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }

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

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand Guncelle = new SqlCommand("UPDATE Urunler SET barkodNo='" + txtBarkodNo.Text + "',UrunAdi='" + txtUrunAdi.Text + "',UrunAciklama='" + txtAciklama.Text + "',UrunKategori='" + cbKategori.Text + "',AlisFiyat='" + txtAlisFiyat.Text + "',SatisFiyat='" + txtSatisFiyat.Text + "',KDVOrani='" + txtKDV.Text + "',Urun_StokAdet='" + txtStok.Text + "',UrunCinsiyet='" + cbCinsiyet.Text + "',UrunMarka='" + cbMarka.Text + "',UrunBeden='" + cbBeden.Text + "',UrunRenk='" + txtRenk.Text + "' WHERE UrunID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Guncelle.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Başarıyla Güncellenmiştir.");
            ClearAll(this.panel1);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand Sil = new SqlCommand("Delete from Urunler Where UrunID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Sil.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Silinmiştir.");
            listele();
            ClearAll(this.panel1);
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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (cbAramaS.Text == "Barkod")
            {
                SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler Where barkodNo Like '%" + txtAra.Text + "%'", bag);
                tablo.Clear();
                bag.Open();
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                bag.Close();
            }
            else if (cbAramaS.Text == "Ürün Adı") 
            {
                SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler Where UrunAdi Like '%" + txtAra.Text + "%'", bag);
                tablo.Clear();
                bag.Open();
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                bag.Close();
            }
            else if (cbAramaS.Text == "Marka") 
            {
                SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler Where UrunMarka Like '%" + txtAra.Text + "%'", bag);
                tablo.Clear();
                bag.Open();
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                bag.Close();
            }
            else if (cbAramaS.Text == "Toptancı") 
            {
                SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler Where U_Toptanci Like '%" + txtAra.Text + "%'", bag);
                tablo.Clear();
                bag.Open();
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                bag.Close();
            }
            else if (cbAramaS.Text == "Ürün Kategorisi") 
            {
                SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler Where UrunKategori Like '%" + txtAra.Text + "%'", bag);
                tablo.Clear();
                bag.Open();
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                bag.Close();
            }
            else if (cbAramaS.Text == "Cinsiyet") 
            {
                SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler Where UrunCinsiyet Like '%" + txtAra.Text + "%'", bag);
                tablo.Clear();
                bag.Open();
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                bag.Close();
            }
            else
            {
                SqlDataAdapter adptr = new SqlDataAdapter("Select * from Urunler Where UrunBeden Like '%" + txtAra.Text + "%'", bag);
                tablo.Clear();
                bag.Open();
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                bag.Close();
            }
            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            UrunGirisi urungir = new UrunGirisi();
            urungir.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearAll(this.panel1);
            cbKategori.ResetText();
            cbCinsiyet.ResetText();
            cbMarka.ResetText();
            cbBeden.ResetText();
        }
    }
}
