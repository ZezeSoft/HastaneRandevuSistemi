using RandevuSistemi.Entity;
namespace RandevuSistemi.WFA.BaseForms
{
    partial class ListelemeBaseForm<T> where T : HastaneBaseClass
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(444, 230);
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(344, 230);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Location = new System.Drawing.Point(344, 201);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(344, 172);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(344, 143);
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(344, 114);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(344, 85);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(344, 56);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(249, 204);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(249, 175);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(249, 146);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(249, 117);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(249, 88);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(249, 59);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 27);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(220, 20);
            this.txtAra.TabIndex = 22;
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(12, 56);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(220, 251);
            this.lstListe.TabIndex = 23;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(395, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 40);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // ListelemeBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 350);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstListe);
            this.Name = "ListelemeBaseForm";
            this.Text = "ListelemeBaseForm";
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
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAra;
        public System.Windows.Forms.ListBox lstListe;
        public System.Windows.Forms.Button btnSil;
    }
}