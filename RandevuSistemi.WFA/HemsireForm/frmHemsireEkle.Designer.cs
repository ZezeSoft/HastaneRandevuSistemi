﻿namespace RandevuSistemi.WFA.HemsireForm
{
    partial class frmHemsireEkle
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
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(210, 269);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(110, 269);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nMaas
            // 
            this.nMaas.DecimalPlaces = 2;
            this.nMaas.Location = new System.Drawing.Point(109, 230);
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
            this.cmbBirim.Location = new System.Drawing.Point(109, 201);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(178, 21);
            this.cmbBirim.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Maaş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Birim";
            // 
            // frmHemsireEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 344);
            this.Controls.Add(this.nMaas);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "frmHemsireEkle";
            this.Text = "frmHemsireEkle";
            this.Load += new System.EventHandler(this.frmHemsireEkle_Load);
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