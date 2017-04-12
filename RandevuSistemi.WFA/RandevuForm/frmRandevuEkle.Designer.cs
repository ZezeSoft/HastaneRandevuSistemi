namespace RandevuSistemi.WFA.RandevuForm
{
    partial class frmRandevuEkle
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRandevu = new System.Windows.Forms.GroupBox();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpRandevuZamani = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbRandevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtAra);
            this.splitContainer1.Panel1.Controls.Add(this.lstListe);
            this.splitContainer1.Panel1.Controls.Add(this.cmbKanGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCinsiyet);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDogumTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.txtTCKN);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.txtAd);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbRandevu);
            this.splitContainer1.Size = new System.Drawing.Size(872, 440);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(8, 44);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(161, 20);
            this.txtAra.TabIndex = 44;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(8, 70);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(161, 303);
            this.lstListe.TabIndex = 45;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Enabled = false;
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Location = new System.Drawing.Point(269, 217);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(139, 21);
            this.cmbKanGrubu.TabIndex = 43;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Enabled = false;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(269, 188);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(139, 21);
            this.cmbCinsiyet.TabIndex = 42;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Enabled = false;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(269, 159);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(139, 20);
            this.dtpDogumTarihi.TabIndex = 41;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Enabled = false;
            this.txtTCKN.Location = new System.Drawing.Point(269, 130);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(139, 20);
            this.txtTCKN.TabIndex = 40;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(269, 101);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(139, 20);
            this.txtSoyad.TabIndex = 39;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(269, 72);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(139, 20);
            this.txtAd.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Kan Grubu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ad";
            // 
            // gbRandevu
            // 
            this.gbRandevu.Controls.Add(this.label9);
            this.gbRandevu.Controls.Add(this.dtpRandevuZamani);
            this.gbRandevu.Controls.Add(this.btnRandevuKaydet);
            this.gbRandevu.Controls.Add(this.flp1);
            this.gbRandevu.Controls.Add(this.cmbDoktor);
            this.gbRandevu.Controls.Add(this.label8);
            this.gbRandevu.Controls.Add(this.cmbBirim);
            this.gbRandevu.Controls.Add(this.label7);
            this.gbRandevu.Location = new System.Drawing.Point(17, 13);
            this.gbRandevu.Name = "gbRandevu";
            this.gbRandevu.Size = new System.Drawing.Size(420, 415);
            this.gbRandevu.TabIndex = 0;
            this.gbRandevu.TabStop = false;
            this.gbRandevu.Text = "Hastane Randevu Sistemi";
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.Location = new System.Drawing.Point(162, 367);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(89, 39);
            this.btnRandevuKaydet.TabIndex = 26;
            this.btnRandevuKaydet.Text = "Randevu Kaydet";
            this.btnRandevuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuKaydet.Click += new System.EventHandler(this.btnRandevuKaydet_Click);
            // 
            // flp1
            // 
            this.flp1.Location = new System.Drawing.Point(14, 121);
            this.flp1.Name = "flp1";
            this.flp1.Padding = new System.Windows.Forms.Padding(5);
            this.flp1.Size = new System.Drawing.Size(371, 240);
            this.flp1.TabIndex = 25;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(54, 83);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(92, 21);
            this.cmbDoktor.TabIndex = 21;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Doktor";
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(55, 43);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(92, 21);
            this.cmbBirim.TabIndex = 22;
            this.cmbBirim.SelectedIndexChanged += new System.EventHandler(this.cmbBirim_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Birim";
            // 
            // dtpRandevuZamani
            // 
            this.dtpRandevuZamani.Location = new System.Drawing.Point(216, 84);
            this.dtpRandevuZamani.Name = "dtpRandevuZamani";
            this.dtpRandevuZamani.Size = new System.Drawing.Size(144, 20);
            this.dtpRandevuZamani.TabIndex = 27;
            this.dtpRandevuZamani.ValueChanged += new System.EventHandler(this.dtpRandevuZamani_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tarih";
            // 
            // frmRandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 440);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRandevuEkle";
            this.Text = "frmRandevuEkle";
            this.Load += new System.EventHandler(this.frmRandevuEkle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbRandevu.ResumeLayout(false);
            this.gbRandevu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtAra;
        public System.Windows.Forms.ListBox lstListe;
        protected internal System.Windows.Forms.ComboBox cmbKanGrubu;
        protected internal System.Windows.Forms.ComboBox cmbCinsiyet;
        protected internal System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        protected internal System.Windows.Forms.TextBox txtTCKN;
        protected internal System.Windows.Forms.TextBox txtSoyad;
        protected internal System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRandevu;
        private System.Windows.Forms.Button btnRandevuKaydet;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.ComboBox cmbDoktor;
        protected internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBirim;
        protected internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpRandevuZamani;
    }
}