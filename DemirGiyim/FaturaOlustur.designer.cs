namespace DemirGiyim
{
    partial class FaturaOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaOlustur));
            this.btnFaturaOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFaturaOlustur
            // 
            this.btnFaturaOlustur.Location = new System.Drawing.Point(557, 13);
            this.btnFaturaOlustur.Name = "btnFaturaOlustur";
            this.btnFaturaOlustur.Size = new System.Drawing.Size(109, 243);
            this.btnFaturaOlustur.TabIndex = 1;
            this.btnFaturaOlustur.Text = "Fatura Oluştur";
            this.btnFaturaOlustur.UseVisualStyleBackColor = true;
            this.btnFaturaOlustur.Click += new System.EventHandler(this.btnFaturaOlustur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 244);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(489, 41);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(0, 13);
            this.lblTT.TabIndex = 3;
            // 
            // FaturaOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 268);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFaturaOlustur);
            this.Controls.Add(this.lblTT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaturaOlustur";
            this.Text = "Demir Giyim | Fatura Oluştur";
            this.Load += new System.EventHandler(this.FaturaOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFaturaOlustur;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTT;
    }
}