using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirGiyim
{
    public partial class AnaForm : Form
    {
        UrunGirisi UrunGirisi = new UrunGirisi();
        public AnaForm()
        {
            InitializeComponent();
        }
        private void btnUrunGirisi_Click(object sender, EventArgs e)
        {
            UrunGirisi.Show();
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            FiyatGor FiyatGor1 = new FiyatGor();
            FiyatGor1.Show();
            this.Hide();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            Stok StokGor = new Stok();
            StokGor.Show();
            this.Hide();
        }

        private void btnToptancilar_Click(object sender, EventArgs e)
        {
            Toptancilar ToptancilarGor = new Toptancilar();
            ToptancilarGor.Show();
            this.Hide();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            AdminGirisi admin = new AdminGirisi();
            admin.Show();
            this.Hide();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
            this.Hide();
        }
    }
}
