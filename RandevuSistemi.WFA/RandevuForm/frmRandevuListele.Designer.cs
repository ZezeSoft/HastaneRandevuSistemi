namespace RandevuSistemi.WFA.RandevuForm
{
    partial class frmRandevuListele
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
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.lblBirim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(80, 28);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(121, 21);
            this.cmbDoktor.TabIndex = 0;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor";
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Location = new System.Drawing.Point(15, 75);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevular.Size = new System.Drawing.Size(340, 192);
            this.dgvRandevular.TabIndex = 4;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.BackColor = System.Drawing.SystemColors.Control;
            this.lblBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirim.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBirim.Location = new System.Drawing.Point(218, 31);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(41, 13);
            this.lblBirim.TabIndex = 5;
            this.lblBirim.Text = "label2";
            // 
            // frmRandevuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 298);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.dgvRandevular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDoktor);
            this.Name = "frmRandevuListele";
            this.Text = "frmRandevuListele";
            this.Load += new System.EventHandler(this.frmRandevuListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Label lblBirim;
    }
}