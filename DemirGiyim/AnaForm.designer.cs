namespace DemirGiyim
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnToptancilar = new System.Windows.Forms.Button();
            this.btnStoklar = new System.Windows.Forms.Button();
            this.btnFiyatGor = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnUrunGirisi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKapat.Image = global::DemirGiyim.Properties.Resources.cikis;
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKapat.Location = new System.Drawing.Point(603, 22);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 74);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Image = global::DemirGiyim.Properties.Resources.kullanici;
            this.btnKullanicilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullanicilar.Location = new System.Drawing.Point(504, 22);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(85, 74);
            this.btnKullanicilar.TabIndex = 6;
            this.btnKullanicilar.Text = "Admin Girişi -\r\n Kullanıcılar";
            this.btnKullanicilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnToptancilar
            // 
            this.btnToptancilar.Image = global::DemirGiyim.Properties.Resources.toptanci;
            this.btnToptancilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToptancilar.Location = new System.Drawing.Point(406, 22);
            this.btnToptancilar.Name = "btnToptancilar";
            this.btnToptancilar.Size = new System.Drawing.Size(82, 74);
            this.btnToptancilar.TabIndex = 5;
            this.btnToptancilar.Text = "Toptancılar";
            this.btnToptancilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnToptancilar.UseVisualStyleBackColor = true;
            this.btnToptancilar.Click += new System.EventHandler(this.btnToptancilar_Click);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Image = global::DemirGiyim.Properties.Resources.stok;
            this.btnStoklar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStoklar.Location = new System.Drawing.Point(308, 22);
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.Size = new System.Drawing.Size(82, 74);
            this.btnStoklar.TabIndex = 4;
            this.btnStoklar.Text = "Stoklar";
            this.btnStoklar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStoklar.UseVisualStyleBackColor = true;
            this.btnStoklar.Click += new System.EventHandler(this.btnStoklar_Click);
            // 
            // btnFiyatGor
            // 
            this.btnFiyatGor.Image = global::DemirGiyim.Properties.Resources.eye;
            this.btnFiyatGor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFiyatGor.Location = new System.Drawing.Point(211, 22);
            this.btnFiyatGor.Name = "btnFiyatGor";
            this.btnFiyatGor.Size = new System.Drawing.Size(82, 74);
            this.btnFiyatGor.TabIndex = 3;
            this.btnFiyatGor.Text = "Fiyat Gör";
            this.btnFiyatGor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiyatGor.UseVisualStyleBackColor = true;
            this.btnFiyatGor.Click += new System.EventHandler(this.btnFiyatGor_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Image = global::DemirGiyim.Properties.Resources.sales;
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatis.Location = new System.Drawing.Point(111, 22);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(82, 74);
            this.btnSatis.TabIndex = 2;
            this.btnSatis.Text = "Satış İşlemi";
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnUrunGirisi
            // 
            this.btnUrunGirisi.BackColor = System.Drawing.SystemColors.Control;
            this.btnUrunGirisi.Image = global::DemirGiyim.Properties.Resources.Untitled_1_copy;
            this.btnUrunGirisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunGirisi.Location = new System.Drawing.Point(10, 22);
            this.btnUrunGirisi.Name = "btnUrunGirisi";
            this.btnUrunGirisi.Size = new System.Drawing.Size(84, 74);
            this.btnUrunGirisi.TabIndex = 1;
            this.btnUrunGirisi.Text = "Ürün Girişi";
            this.btnUrunGirisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunGirisi.UseVisualStyleBackColor = false;
            this.btnUrunGirisi.Click += new System.EventHandler(this.btnUrunGirisi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemirGiyim.Properties.Resources.demirgiyim;
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 388);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(702, 507);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKullanicilar);
            this.Controls.Add(this.btnToptancilar);
            this.Controls.Add(this.btnStoklar);
            this.Controls.Add(this.btnFiyatGor);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnUrunGirisi);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Text = "Demir Giyim Otomasyon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrunGirisi;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnFiyatGor;
        private System.Windows.Forms.Button btnStoklar;
        private System.Windows.Forms.Button btnToptancilar;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnKapat;

    }
}

