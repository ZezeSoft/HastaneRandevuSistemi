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

namespace RandevuSistemi.WFA.PersonelForm
{
    public partial class frmPersonelEkle : EklemeBaseForm
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            cmbGorev.ValueMember = "Gorev";
            cmbGorev.DataSource = new GorevRepo().GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Personel eklenenPersonel = new Personel();

                eklenenPersonel.Ad = txtAd.Text;
                eklenenPersonel.Soyad = txtSoyad.Text;
                eklenenPersonel.TCKN = txtTCKN.Text;
                eklenenPersonel.DogumTarihi = dtpDogumTarihi.Value;
                eklenenPersonel.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                eklenenPersonel.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;
                eklenenPersonel.GorevID = (cmbGorev.SelectedItem as Gorevler).ID;

                new PersonelRepo().Insert(eklenenPersonel);
                MessageBox.Show(eklenenPersonel.Ad + " " + eklenenPersonel.Soyad + " isimli hasta sisteme eklenmiştir");
            }
            catch (Exception)
            {

                MessageBox.Show("Eklenecek personelin bilgilerini giriniz");
            }          
        }
    }
}
