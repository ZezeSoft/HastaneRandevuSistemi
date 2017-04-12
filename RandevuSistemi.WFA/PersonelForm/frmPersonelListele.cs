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

namespace RandevuSistemi.WFA.PersonelForm
{
    public partial class frmPersonelListele : PersonelListelemeIntermediate
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        public List<Personel> PersonelListesi { get; set; }
        public Personel SeciliPersonel { get; set; }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            cmbGorev.ValueMember = "Gorev";
            cmbGorev.DataSource = new GorevRepo().GetAll();

            PersonelListesi = new PersonelRepo().GetAll();
            ListeyiDoldur(PersonelListesi);
        }

        private void ListeyiDoldur(List<Personel> personelListesi)
        {
            lstListe.ValueMember = "Ad" + "Soyad";
            lstListe.DataSource = personelListesi;
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;

            SeciliPersonel = lstListe.SelectedItem as Personel;

            txtAd.Text = SeciliPersonel.Ad;
            txtSoyad.Text = SeciliPersonel.Soyad;
            txtTCKN.Text = SeciliPersonel.TCKN;
            dtpDogumTarihi.Value = SeciliPersonel.DogumTarihi;
            cmbCinsiyet.SelectedIndex = SeciliPersonel.CinsiyetID - 1;
            cmbKanGrubu.SelectedIndex = SeciliPersonel.KangrupID - 1;
            cmbGorev.SelectedIndex = SeciliPersonel.GorevID - 1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = new PersonelRepo().GetAll().Where(x => x.ID == SeciliPersonel.ID).FirstOrDefault();

            new PersonelRepo().Delete(sonuc);

            MessageBox.Show(sonuc.Ad + " " + sonuc.Soyad + " isimli personel sistemden silinmiştir");
            ListeyiDoldur(new PersonelRepo().GetAll());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ListeyiDoldur(PersonelRepo.Arama(txtAra.Text));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SeciliPersonel.Ad = txtAd.Text;
                SeciliPersonel.Soyad = txtSoyad.Text;
                SeciliPersonel.TCKN = txtTCKN.Text;
                SeciliPersonel.DogumTarihi = dtpDogumTarihi.Value;
                SeciliPersonel.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                SeciliPersonel.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;
                SeciliPersonel.GorevID = (cmbGorev.SelectedItem as Gorevler).ID;

                new PersonelRepo().Update();
                MessageBox.Show("Güncelleme işleminiz yapıldı");

                ListeyiDoldur(new PersonelRepo().GetAll());
            }
            catch (Exception)
            {

                MessageBox.Show("Güncellemek istediğiniz bilgileri giriniz");
            }
        }
    }
}
