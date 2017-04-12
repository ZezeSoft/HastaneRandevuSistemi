namespace RandevuSistemi.WFA.HastaForm
{
    partial class frmHastaListele
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
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 17);
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstListe
            // 
            this.lstListe.Location = new System.Drawing.Point(12, 47);
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(443, 218);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(343, 218);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Location = new System.Drawing.Point(343, 189);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(343, 160);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(343, 131);
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(343, 102);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(343, 73);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(343, 44);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(248, 192);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(248, 163);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(248, 134);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 105);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(248, 76);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(248, 47);
            // 
            // frmHastaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Name = "frmHastaListele";
            this.Text = "frmHastaListele";
            this.Load += new System.EventHandler(this.frmHastaListele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}