using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace DemirGiyim
{
    public partial class FaturaOlustur : Form
    {
        public FaturaOlustur()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=DemirGiyim;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void btnFaturaOlustur_Click(object sender, EventArgs e)
        {
            FaturaYazdir f = new FaturaYazdir();
            f.ShowDialog();
            this.Hide();
        }
        void getir()
        {
            SqlCommand kmt = new SqlCommand("Select GF_BarkodNo,GF_Urunadi,GF_Fiyatı,GF_Adet,GF_Tutar,Satis.Tutar from GeciciFatura inner join Satis on Satis.sID=GeciciFatura.GF_SatisID", bag);
            bag.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(kmt);
            DataTable tab = new DataTable();
            adpt.Fill(tab);
            dataGridView1.DataSource = tab;
            bag.Close();
        }
        public void FaturaOlustur_Load(object sender, EventArgs e)
        {
            //SqlDataReader oku;
            //bag.Open();
            //cmd.Connection = bag;
            //cmd.CommandText = "Select SUM(GF_Tutar) from GeciciFatura";
            //oku = cmd.ExecuteReader();
            //while (oku.Read())
            //{
            //    lblTT.Text = oku[0].ToString();
            //}
            //bag.Close();
            getir();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
