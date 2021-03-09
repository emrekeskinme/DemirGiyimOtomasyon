namespace DemirGiyim
{
    partial class Rapor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAramaSecenegi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTStok = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblToptanciSayisi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMarkaSayisi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKullaniciSayisi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblToplamSatilanUrun = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbAd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbAramaSecenegi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRaporla);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 84);
            this.panel1.TabIndex = 1;
            // 
            // cbAd
            // 
            this.cbAd.FormattingEnabled = true;
            this.cbAd.Items.AddRange(new object[] {
            "Ürün Adı"});
            this.cbAd.Location = new System.Drawing.Point(302, 13);
            this.cbAd.Name = "cbAd";
            this.cbAd.Size = new System.Drawing.Size(121, 21);
            this.cbAd.TabIndex = 8;
            this.cbAd.SelectedIndexChanged += new System.EventHandler(this.cbUrunAdi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aranılan: ";
            // 
            // cbAramaSecenegi
            // 
            this.cbAramaSecenegi.FormattingEnabled = true;
            this.cbAramaSecenegi.Items.AddRange(new object[] {
            "Hepsi",
            "Ürün Adı",
            "Satış Yapan"});
            this.cbAramaSecenegi.Location = new System.Drawing.Point(111, 13);
            this.cbAramaSecenegi.Name = "cbAramaSecenegi";
            this.cbAramaSecenegi.Size = new System.Drawing.Size(121, 21);
            this.cbAramaSecenegi.TabIndex = 6;
            this.cbAramaSecenegi.SelectedIndexChanged += new System.EventHandler(this.cbAramaSecenegi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arama Seçeneği: ";
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(441, 13);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(78, 53);
            this.btnRaporla.TabIndex = 4;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(302, 46);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(121, 20);
            this.date2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Tarih";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(111, 45);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(121, 20);
            this.date1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toplam Ürün Çeşidi: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTStok);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lblToptanciSayisi);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblMarkaSayisi);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblTT);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblKullaniciSayisi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblToplamSatilanUrun);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblToplamUrun);
            this.panel2.Location = new System.Drawing.Point(551, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 377);
            this.panel2.TabIndex = 9;
            // 
            // lblTStok
            // 
            this.lblTStok.AutoSize = true;
            this.lblTStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTStok.ForeColor = System.Drawing.Color.Red;
            this.lblTStok.Location = new System.Drawing.Point(150, 325);
            this.lblTStok.Name = "lblTStok";
            this.lblTStok.Size = new System.Drawing.Size(0, 13);
            this.lblTStok.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "Toplam Stok: ";
            // 
            // lblToptanciSayisi
            // 
            this.lblToptanciSayisi.AutoSize = true;
            this.lblToptanciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToptanciSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblToptanciSayisi.Location = new System.Drawing.Point(150, 280);
            this.lblToptanciSayisi.Name = "lblToptanciSayisi";
            this.lblToptanciSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblToptanciSayisi.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Toptancı Sayısı: ";
            // 
            // lblMarkaSayisi
            // 
            this.lblMarkaSayisi.AutoSize = true;
            this.lblMarkaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarkaSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblMarkaSayisi.Location = new System.Drawing.Point(150, 235);
            this.lblMarkaSayisi.Name = "lblMarkaSayisi";
            this.lblMarkaSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblMarkaSayisi.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Marka Sayısı: ";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTT.ForeColor = System.Drawing.Color.Red;
            this.lblTT.Location = new System.Drawing.Point(150, 185);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(0, 13);
            this.lblTT.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Toplam Satış Tutarı: ";
            // 
            // lblKullaniciSayisi
            // 
            this.lblKullaniciSayisi.AutoSize = true;
            this.lblKullaniciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblKullaniciSayisi.Location = new System.Drawing.Point(150, 130);
            this.lblKullaniciSayisi.Name = "lblKullaniciSayisi";
            this.lblKullaniciSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciSayisi.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kullanıcı Sayısı:  ";
            // 
            // lblToplamSatilanUrun
            // 
            this.lblToplamSatilanUrun.AutoSize = true;
            this.lblToplamSatilanUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSatilanUrun.ForeColor = System.Drawing.Color.Red;
            this.lblToplamSatilanUrun.Location = new System.Drawing.Point(150, 83);
            this.lblToplamSatilanUrun.Name = "lblToplamSatilanUrun";
            this.lblToplamSatilanUrun.Size = new System.Drawing.Size(0, 13);
            this.lblToplamSatilanUrun.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Toplam Satılan Ürün: ";
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUrun.ForeColor = System.Drawing.Color.Red;
            this.lblToplamUrun.Location = new System.Drawing.Point(150, 38);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(0, 13);
            this.lblToplamUrun.TabIndex = 9;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.ComboBox cbAramaSecenegi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblToplamSatilanUrun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTStok;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblToptanciSayisi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMarkaSayisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKullaniciSayisi;
    }
}