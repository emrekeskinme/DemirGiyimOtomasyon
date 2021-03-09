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
    public partial class FiyatGor : Form
    {
        public FiyatGor()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");

        private void btnKapat_Click(object sender, EventArgs e)
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

        DataTable tablo = new DataTable();
        private void btnAra_Click(object sender, EventArgs e)
        {
            ClearAll(this.panel1);
            int barkod = 0;
            if (int.TryParse(txtAra.Text, out barkod))
            {
                SqlCommand cmd = new SqlCommand("select * from Urunler where barkodNo = @barkodNo", bag);
                cmd.Parameters.AddWithValue("@barkodNo", barkod);
                bag.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtUrunAdi.Text += dr["UrunAdi"].ToString();
                    txtStokAdedi.Text += dr["Urun_StokAdet"].ToString();
                    txtSatisFiyati.Text += dr["SatisFiyat"].ToString() + " TL";
                    txtCinsiyet.Text += dr["UrunCinsiyet"].ToString();

                    panel1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    txtUrunAdi.Visible = true;
                    txtStokAdedi.Visible = true;
                    txtSatisFiyati.Visible = true;
                }
                else
                {
                    panel1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    txtUrunAdi.Visible = false;
                    txtStokAdedi.Visible = false;
                    txtSatisFiyati.Visible = false;
                    MessageBox.Show("Bu Barkod Numarası İle Ürün Bulunmamaktadır! Tekrar Deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                bag.Close();
            }
            
            txtAra.Text = "";
            txtAra.Focus();
        }

        private void FiyatGor_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtUrunAdi.Visible = false;
            txtStokAdedi.Visible = false;
            txtSatisFiyati.Visible = false;
        }
    }
}
