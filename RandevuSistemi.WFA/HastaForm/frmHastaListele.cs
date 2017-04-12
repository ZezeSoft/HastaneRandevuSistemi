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
    public partial class frmHastaListele : HastaListelemeIntermediate
    {
        public frmHastaListele()
        {
            InitializeComponent();
        }

        public List<Hasta> HastaListesi { get; set; }
        public Hasta SeciliHasta { get; set; }

        private void frmHastaListele_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            HastaListesi = new HastaRepo().GetAll();
            ListeyiDoldur(HastaListesi);
        }

        private void ListeyiDoldur(List<Hasta> hastaListesi)
        {
            lstListe.ValueMember = "Ad" + "Soyad";
            lstListe.DataSource = hastaListesi;
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;

            SeciliHasta = lstListe.SelectedItem as Hasta;

            txtAd.Text = SeciliHasta.Ad;
            txtSoyad.Text = SeciliHasta.Soyad;
            txtTCKN.Text = SeciliHasta.TCKN;
            dtpDogumTarihi.Value = SeciliHasta.DogumTarihi;
            cmbCinsiyet.SelectedIndex = SeciliHasta.CinsiyetID - 1;
            cmbKanGrubu.SelectedIndex = SeciliHasta.KangrupID - 1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SeciliHasta.Ad = txtAd.Text;
                SeciliHasta.Soyad = txtSoyad.Text;
                SeciliHasta.TCKN = txtTCKN.Text;
                SeciliHasta.DogumTarihi = dtpDogumTarihi.Value;
                SeciliHasta.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                SeciliHasta.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;

                new HastaRepo().Update();
                MessageBox.Show("Güncelleme işleminiz yapıldı");

                ListeyiDoldur(new HastaRepo().GetAll());
            }
            catch (Exception)
            {

                MessageBox.Show("Güncellemek istediğiniz bilgileri giriniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = new HastaRepo().GetAll().Where(x => x.ID == SeciliHasta.ID).FirstOrDefault();

            new HastaRepo().Delete(sonuc);

            MessageBox.Show(sonuc.Ad + " " + sonuc.Soyad + " isimli hasta sistemden silinmiştir");
            ListeyiDoldur(new HastaRepo().GetAll());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ListeyiDoldur(HastaRepo.Arama(txtAra.Text));
        }

    }
}
