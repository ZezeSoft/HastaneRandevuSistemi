namespace RandevuSistemi.WFA.HemsireForm
{
    partial class frmHemsireListele
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
            this.nMaas = new System.Windows.Forms.NumericUpDown();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstListe
            // 
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(398, 315);
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(447, 270);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(347, 270);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Location = new System.Drawing.Point(346, 172);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(346, 143);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(346, 114);
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(346, 85);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(346, 56);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(346, 27);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(251, 175);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(251, 146);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(251, 117);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(251, 88);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(251, 59);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(251, 30);
            // 
            // nMaas
            // 
            this.nMaas.DecimalPlaces = 2;
            this.nMaas.Location = new System.Drawing.Point(347, 230);
            this.nMaas.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nMaas.Name = "nMaas";
            this.nMaas.Size = new System.Drawing.Size(178, 20);
            this.nMaas.TabIndex = 35;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(347, 201);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(178, 21);
            this.cmbBirim.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Maaş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Birim";
            // 
            // frmHemsireListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 369);
            this.Controls.Add(this.nMaas);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "frmHemsireListele";
            this.Text = "frmHemsireListele";
            this.Load += new System.EventHandler(this.frmHemsireListele_Load);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.lstListe, 0);
            this.Controls.SetChildIndex(this.txtAra, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.txtTCKN, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.cmbKanGrubu, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.btnTemizle, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbBirim, 0);
            this.Controls.SetChildIndex(this.nMaas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nMaas;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}