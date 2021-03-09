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
    public partial class Toptancilar : Form
    {
        public Toptancilar()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");

        private void Toptancilar_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnToptanciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert INTO Toptancilar (ToptanciAdi,SirketYetkilisi,T_Email,T_İsTel,T_GsmTel,VergiDairesi,VergiNo) VALUES ('" + txtToptanciAdi.Text + "','" + txtSirketYetkilisi.Text + "','" + txtEmail.Text + "','" + txtİsTel.Text + "','" + txtGsmTel.Text + "','" + txtVD.Text + "','" + txtVN.Text + "')", bag);
            bag.Open();
            ekle.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Ekleme İşlemi Başarı İle Gerçekleştirilmiştir.");
            listele();
            ClearAll(this.panel1);
            
        }

        DataTable tablo = new DataTable();
        void listele()
        {
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from Toptancilar", bag);
            tablo.Clear();
            bag.Open();
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }

        private void btnAnaEkranaDon_Click(object sender, EventArgs e)
        {
            AnaForm Anaform1 = new AnaForm();
            Anaform1.Show();
            this.Hide();
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

        private void btnToptanciSil_Click(object sender, EventArgs e)
        {
            SqlCommand Sil = new SqlCommand("Delete from Toptancilar Where ToptanciID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Sil.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Silinmiştir.");
            listele();
            ClearAll(this.panel1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtToptanciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSirketYetkilisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtİsTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtGsmTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtVD.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtVN.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll(this.panel1);
        }

        private void btnToptanciDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand Guncelle = new SqlCommand("UPDATE Toptancilar SET ToptanciAdi='" + txtToptanciAdi.Text + "',SirketYetkilisi='" + txtSirketYetkilisi.Text + "',T_Email='" + txtEmail.Text + "',T_İsTel='" + txtİsTel.Text + "',T_GsmTel='" + txtGsmTel.Text + "',VergiDairesi='" + txtVD.Text + "',VergiNo='" + txtVN.Text + "' WHERE ToptanciID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            Guncelle.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Seçiminiz Başarıyla Güncellenmiştir.");
            ClearAll(this.panel1);
            listele();
            
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from Toptancilar Where ToptanciAdi Like '%"+txtAra.Text+"%'", bag);
            tablo.Clear();
            bag.Open();
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }
    }
}
