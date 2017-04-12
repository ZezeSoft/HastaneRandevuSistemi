using RandevuSistemi.BLL;
using RandevuSistemi.Entity;
using RandevuSistemi.WFA.BaseForms;
using RandevuSistemi.WFA.HemsireForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemi.WFA.DoktorForm
{
    public partial class frmDoktorEkle : EklemeBaseForm
    {
        public frmDoktorEkle()
        {
            InitializeComponent();
        }

        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            cmbBirim.ValueMember = "Birim";
            cmbBirim.DataSource = new BirimRepo().GetAll();

            cmbUnvan.ValueMember = "Unvan";
            cmbUnvan.DataSource = new UnvanRepo().GetAll();

        }
        public Doktor SeciliDoktor { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SeciliDoktor = new Doktor();
                SeciliDoktor.Ad = txtAd.Text;
                SeciliDoktor.Soyad = txtSoyad.Text;
                SeciliDoktor.TCKN = txtTCKN.Text;
                SeciliDoktor.DogumTarihi = dtpDogumTarihi.Value;
                SeciliDoktor.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                SeciliDoktor.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;
                SeciliDoktor.BirimID = (cmbBirim.SelectedItem as Birimler).ID;
                SeciliDoktor.Maas = nMaas.Value;
                SeciliDoktor.UnvanID = (cmbUnvan.SelectedItem as Unvanlar).ID;

                new DoktorRepo().Insert(SeciliDoktor);

                if (clstHemsireler.CheckedItems.Count > 0)
                {
                    new frmHemsireEkle().HemsireninDoktoru = SeciliDoktor;

                    Hemsire doktorunHemsiresi = clstHemsireler.SelectedItem as Hemsire;

                    foreach (Hemsire item in clstHemsireler.CheckedItems)
                    {
                        Hemsire hmsr = new Hemsire();
                        var sonuc = new HemsireRepo().GetAll().Where(x => x.ID == item.ID).FirstOrDefault();
                        sonuc.DoktorID = SeciliDoktor.ID;
                        new HemsireRepo().Update();
                    }

                }

                MessageBox.Show(SeciliDoktor.Ad + " " + SeciliDoktor.Soyad + " isimli doktor başarıyla eklenmiştir");
            }
            catch (Exception)
            {

                MessageBox.Show("Kaydedilecek doktorun bilgilerini giriniz");
            }


        }

        public Birimler SeciliBirim { get; set; }
        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirim.SelectedIndex == -1) return;

            clstHemsireler.Items.Clear();
            SeciliBirim = cmbBirim.SelectedItem as Birimler;

            var hemsireler = new HemsireRepo().GetAll().Where(x => x.BirimID == SeciliBirim.ID && x.DoktorID == null).ToList();
            hemsireler.ForEach(x => clstHemsireler.Items.Add(x));

        }

        private void clstHemsireler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
