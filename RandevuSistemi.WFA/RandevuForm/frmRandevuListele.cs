using RandevuSistemi.BLL;
using RandevuSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemi.WFA.RandevuForm
{
    public partial class frmRandevuListele : Form
    {
        public frmRandevuListele()
        {
            InitializeComponent();
        }

        public Doktor SeciliDoktor { get; set; }
        private void frmRandevuListele_Load(object sender, EventArgs e)
        {
            cmbDoktor.ValueMember = "Ad" + "Soyad";
            cmbDoktor.DataSource = new DoktorRepo().GetAll();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeciliDoktor = cmbDoktor.SelectedItem as Doktor;

            lblBirim.Text = new BirimRepo().GetById(SeciliDoktor.BirimID).Birim;

            dgvRandevular.DataSource = new RandevuRepo().GetAll().Where(x => x.DoktorID == SeciliDoktor.ID).Select(x => new 
            { Tarih=x.RandevuZamani, 
               SiraNumarasi = x.SiraNumarasi,
               HastaAdi = x.HastanınRandevusu
            }).OrderBy(x=>x.Tarih).ToList();

        }
    }
}
