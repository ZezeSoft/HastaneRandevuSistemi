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

namespace RandevuSistemi.WFA.HemsireForm
{
    public partial class frmHemsireListele : HemsireListelemeIntermediate
    {
        public frmHemsireListele()
        {
            InitializeComponent();
        }

        public List<Hemsire> HemsireListesi { get; set; }
        public Hemsire SeciliHemsire { get; set; }
        private void frmHemsireListele_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            cmbBirim.ValueMember = "Birim";
            cmbBirim.DataSource = new BirimRepo().GetAll();

            HemsireListesi = new HemsireRepo().GetAll();
            ListeyiDoldur(HemsireListesi);
        }

        private void ListeyiDoldur(List<Hemsire> hemsireListesi)
        {
            lstListe.ValueMember = "Ad" + "Soyad";
            lstListe.DataSource = hemsireListesi;
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;

            SeciliHemsire = lstListe.SelectedItem as Hemsire;

            txtAd.Text = SeciliHemsire.Ad;
            txtSoyad.Text = SeciliHemsire.Soyad;
            txtTCKN.Text = SeciliHemsire.TCKN;
            dtpDogumTarihi.Value = SeciliHemsire.DogumTarihi;
            cmbCinsiyet.SelectedIndex = SeciliHemsire.CinsiyetID - 1;
            cmbKanGrubu.SelectedIndex = SeciliHemsire.KangrupID - 1;
            cmbBirim.SelectedIndex = SeciliHemsire.BirimID-1;
            nMaas.Value = SeciliHemsire.Maas;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SeciliHemsire.Ad = txtAd.Text;
                SeciliHemsire.Soyad = txtSoyad.Text;
                SeciliHemsire.TCKN = txtTCKN.Text;
                SeciliHemsire.DogumTarihi = dtpDogumTarihi.Value;
                SeciliHemsire.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                SeciliHemsire.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;
                SeciliHemsire.BirimID = (cmbBirim.SelectedItem as Birimler).ID;
                SeciliHemsire.Maas = nMaas.Value;

                new HemsireRepo().Update();
                MessageBox.Show("Güncelleme işlemini yapıldı");

                ListeyiDoldur(new HemsireRepo().GetAll());
            }
            catch (Exception)
            {

                MessageBox.Show("Güncellenec bilgileri giriniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = new HemsireRepo().GetAll().Where(x => x.ID == SeciliHemsire.ID).FirstOrDefault();

            new HemsireRepo().Delete(sonuc);

            MessageBox.Show(sonuc.Ad+" "+sonuc.Soyad+" isimli hemşire sistemden silinmiştir");
            ListeyiDoldur(new HemsireRepo().GetAll());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ListeyiDoldur(HemsireRepo.Arama(txtAra.Text));
        }

    }
}
