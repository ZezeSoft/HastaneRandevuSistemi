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

namespace RandevuSistemi.WFA.HemsireForm
{
    public partial class frmHemsireEkle : EklemeBaseForm
    {
        public frmHemsireEkle()
        {
            InitializeComponent();
        }

        public Doktor HemsireninDoktoru { get; set; }
        private void frmHemsireEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            cmbBirim.ValueMember = "Birim";
            cmbBirim.DataSource = new BirimRepo().GetAll();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Hemsire eklenenHemsire = new Hemsire();

                eklenenHemsire.Ad = txtAd.Text;
                eklenenHemsire.Soyad = txtSoyad.Text;
                eklenenHemsire.TCKN = txtTCKN.Text;
                eklenenHemsire.DogumTarihi = dtpDogumTarihi.Value;
                eklenenHemsire.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                eklenenHemsire.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;
                eklenenHemsire.BirimID = (cmbBirim.SelectedItem as Birimler).ID;
                eklenenHemsire.Maas = nMaas.Value;

                if (HemsireninDoktoru != null)
                    eklenenHemsire.DoktorID = HemsireninDoktoru.ID;

                new HemsireRepo().Insert(eklenenHemsire);

                MessageBox.Show(eklenenHemsire.Ad + " " + eklenenHemsire.Soyad + " isimli hemşire sisteme eklenmiştir");
            }
            catch (Exception)
            {

                MessageBox.Show("Eklenecek hemşirenin bilgilerini giriniz");
            }
        }
    }
}
