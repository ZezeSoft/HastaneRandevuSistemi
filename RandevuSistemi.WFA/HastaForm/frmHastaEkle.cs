using RandevuSistemi.BLL;
using RandevuSistemi.Entity;
using RandevuSistemi.WFA.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemi.WFA.HastaForm
{
    public partial class frmHastaEkle : EklemeBaseForm
    {
        public frmHastaEkle()
        {
            InitializeComponent();
        }

        private void frmHastaEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                Hasta eklenenHasta = new Hasta();

                eklenenHasta.Ad = txtAd.Text;
                eklenenHasta.Soyad = txtSoyad.Text;
                eklenenHasta.TCKN = txtTCKN.Text;
                eklenenHasta.DogumTarihi = dtpDogumTarihi.Value;
                eklenenHasta.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                eklenenHasta.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;

                new HastaRepo().Insert(eklenenHasta);
                MessageBox.Show(eklenenHasta.Ad + " " + eklenenHasta.Soyad + " isimli hasta sisteme eklenmiştir");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen hasta bilgilerini giriniz");
            }

        }
    }
}
