namespace RandevuSistemi.WFA.PersonelForm
{
    partial class frmPersonelEkle
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(210, 230);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(110, 230);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Location = new System.Drawing.Point(110, 169);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Görev";
            // 
            // cmbGorev
            // 
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Location = new System.Drawing.Point(110, 196);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(178, 21);
            this.cmbGorev.TabIndex = 36;
            // 
            // frmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 312);
            this.Controls.Add(this.cmbGorev);
            this.Controls.Add(this.label7);
            this.Name = "frmPersonelEkle";
            this.Text = "frmPersonelEkle";
            this.Load += new System.EventHandler(this.frmPersonelEkle_Load);
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
            this.Controls.SetChildIndex(this.cmbGorev, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGorev;
    }
}