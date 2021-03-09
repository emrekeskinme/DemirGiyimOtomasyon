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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();

        private void btnAnaEkranaDon_Click(object sender, EventArgs e)
        {
            AnaForm ana = new AnaForm();
            ana.Show();
            this.Close();
        }

        DataTable tablo = new DataTable();
        int toplamTutar = 0;
        int toplamFiyat = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnCikar.Enabled = true;
            string urunadi = "";
            int miktar = int.Parse(numericUpDown1.Value.ToString());
            int fiyat = 0;


            SqlCommand kmt = new SqlCommand("Select UrunAdi, SatisFiyat from Urunler Where barkodNo='" + txtBarkod.Text + "'", bag);

            bag.Open();
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                urunadi = dr[0].ToString();
                fiyat = Convert.ToInt32(dr[1].ToString());
            }
            bag.Close();

            toplamFiyat = miktar * fiyat;

            ListViewItem lwitem = new ListViewItem();
            lwitem.Text = txtBarkod.Text;
            lwitem.SubItems.Add(urunadi.ToString());
            lwitem.SubItems.Add(fiyat.ToString());
            lwitem.SubItems.Add(miktar.ToString());
            lwitem.SubItems.Add(toplamFiyat.ToString());

            listView1.Items.Add(lwitem);
            toplamTutar += toplamFiyat;
            txtToplamTutar.Text = toplamTutar.ToString() + " TL";
        }

        private void btnİndirimUygula_Click(object sender, EventArgs e)
        {
            double tutar = 0;

            tutar = Convert.ToDouble(txtToplamTutar.Text.Replace(" TL", String.Empty));
            double indirim = Convert.ToDouble(txtİndirim.Text);
            if (tutar>=indirim)
            {
                txtToplamTutar.Text = (tutar - indirim).ToString() + " TL";
                lblİndirim.Enabled = false;
                txtİndirim.Enabled = false;
                btnİndirimUygula.Enabled = false;
                btnCikar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Toplam Tutardan Fazla İndirim Yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                int CikarilanUrun = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                toplamTutar -= CikarilanUrun;
                txtToplamTutar.Text = toplamTutar.ToString() + " TL";
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }
            catch (Exception)
            {
                MessageBox.Show("Önce listeden silinecek ürünü seçmelisiniz.", "Uyarı");
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                SqlCommand kmt = new SqlCommand("insert into satis(Tutar,Tarih) values (@STutar,@STarih);Select @@IDENTITY", bag);
                kmt.Parameters.AddWithValue("@STutar", txtToplamTutar.Text.Replace(" TL", String.Empty));
                kmt.Parameters.AddWithValue("@STarih", DateTime.Now);
                bag.Open();

                int satisID = Convert.ToInt32(kmt.ExecuteScalar());
                bag.Close();

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    SqlCommand kmt2 = new SqlCommand("insert into SatisDetay(SatisID, BarkodNo, UrunAdet, SatisYapan) values (@SatisID,@Barkod,@UrunAdet,@SatisYapan)", bag);
                    kmt2.Parameters.AddWithValue("@SatisID", satisID);
                    kmt2.Parameters.AddWithValue("@Barkod", int.Parse(listView1.Items[i].SubItems[0].Text));
                    kmt2.Parameters.AddWithValue("@UrunAdet", int.Parse(listView1.Items[i].SubItems[3].Text));
                    kmt2.Parameters.AddWithValue("@SatisYapan", cbSatisYapan.Text);
                    bag.Open();
                    kmt2.ExecuteNonQuery();
                    bag.Close();
                    SqlCommand kmt3 = new SqlCommand("Update Urunler Set Urun_StokAdet=Urun_StokAdet-" + int.Parse(listView1.Items[i].SubItems[3].Text) + "Where urunID=" + int.Parse(listView1.Items[i].SubItems[0].Text) + "", bag);
                    bag.Open();
                    kmt3.ExecuteNonQuery();
                    bag.Close();
                }

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into Fatura(F_BarkodNo, F_Urunadi, F_Fiyatı, F_Adet, F_Tutar,F_SatisID) values (@F_Barkod,@F_UrunAdi,@F_Fiyati,@F_Adet,@F_Tutar,@F_SatisID)", bag);
                    cmd.Parameters.AddWithValue("@F_Barkod", int.Parse(listView1.Items[i].SubItems[0].Text));
                    cmd.Parameters.AddWithValue("@F_UrunAdi", listView1.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("@F_Fiyati", int.Parse(listView1.Items[i].SubItems[2].Text));
                    cmd.Parameters.AddWithValue("@F_Adet", int.Parse(listView1.Items[i].SubItems[3].Text));
                    cmd.Parameters.AddWithValue("@F_Tutar", int.Parse(listView1.Items[i].SubItems[4].Text));
                    cmd.Parameters.AddWithValue("@F_SatisID", satisID);
                    bag.Open();
                    cmd.ExecuteNonQuery();
                    bag.Close();
                }

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into GeciciFatura(GF_BarkodNo, GF_Urunadi, GF_Fiyatı, GF_Adet, GF_Tutar, GF_SatisID) values (@GF_Barkod,@GF_UrunAdi,@GF_Fiyati,@GF_Adet,@GF_Tutar,@GF_SatisID)", bag);
                    cmd.Parameters.AddWithValue("@GF_Barkod", int.Parse(listView1.Items[i].SubItems[0].Text));
                    cmd.Parameters.AddWithValue("@GF_UrunAdi", listView1.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("@GF_Fiyati", int.Parse(listView1.Items[i].SubItems[2].Text));
                    cmd.Parameters.AddWithValue("@GF_Adet", int.Parse(listView1.Items[i].SubItems[3].Text));
                    cmd.Parameters.AddWithValue("@GF_Tutar", int.Parse(listView1.Items[i].SubItems[4].Text));
                    cmd.Parameters.AddWithValue("@GF_SatisID", satisID);
                    bag.Open();
                    cmd.ExecuteNonQuery();
                    bag.Close();
                }
                txtToplamTutar.ResetText();
                MessageBox.Show("Satış İşleminiz Gerçekleşmiştir.");
                //Satis ac = new Satis();
                //ac.Show();
                this.Close();
                //FaturaOlustur fatolustur = new FaturaOlustur();
                //fatolustur.ShowDialog();
            }
            else
            {
                MessageBox.Show("Satış Listesi Boş!");
            }
            listView1.Items.Clear();
            txtBarkod.Clear();
            numericUpDown1.ResetText();
            txtİndirim.Clear();
            txtİndirim.Enabled = true;
            lblİndirim.Enabled = true;
            btnCikar.Enabled = true;
            btnİndirimUygula.Enabled = true;
        }
        void SatisYapanListele()
        {
            cbSatisYapan.Items.Clear();
            SqlDataReader oku;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Kullanicilar";
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cbSatisYapan.Items.Add(oku[1].ToString());
            }
            bag.Close();
            cbSatisYapan.SelectedText = "Ali Keskin";
        }
        private void Satis_Load(object sender, EventArgs e)
        {
            SatisYapanListele();
        }

        private void txtToplamTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
