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
    public partial class frmRandevuEkle : Form
    {
        public frmRandevuEkle()
        {
            InitializeComponent();
            Saatler = RandevuRepo.SaatleriGetir();
        }

        public List<Hasta> ListelenecekHasta { get; set; }
        public Hasta SeciliHasta { get; set; }
        public Doktor SeciliDoktor { get; set; }
        public Button SeciliButon { get; set; }
        public List<string> Saatler { get; set; }
        public Birimler secilenBirim { get; set; }
        private void frmRandevuEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            cmbBirim.ValueMember = "Birim";
            cmbBirim.DataSource = new BirimRepo().GetAll();

            ListelenecekHasta = new HastaRepo().GetAll();
            ListeyiDoldur(ListelenecekHasta);
        }

        private void ListeyiDoldur(List<Hasta> listelenecekHasta)
        {
            lstListe.ValueMember = "Ad" + "Soyad";
            lstListe.DataSource = listelenecekHasta;
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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ListeyiDoldur(HastaRepo.Arama(txtAra.Text));
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Birimler brm = cmbBirim.SelectedItem as Birimler;

            cmbDoktor.ValueMember = "Ad"+"Soyad";
            cmbDoktor.DataSource = new DoktorRepo().GetAll().Where(x => x.BirimID == brm.ID).ToList();

        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedItem == null)
            {
                SeciliDoktor = null;
                flp1.Visible = false;
                return;
            }
            SeciliDoktor = cmbDoktor.SelectedItem as Doktor;
            flp1.Visible = true;
            ButonDoldur();
            SeciliButon = null;

            var randevular = new RandevuRepo().GetAll().Where(x => x.DoktorID != null && x.DoktorID == SeciliDoktor.ID && (x.RandevuZamani.Year==dtpRandevuZamani.Value.Year && x.RandevuZamani.Month==dtpRandevuZamani.Value.Month &&x.RandevuZamani.Day==dtpRandevuZamani.Value.Day)).ToList();
            if (randevular.Count > 0)
            {
                foreach (var item in randevular)
                {
                    ButonKapat(Saatler[item.SiraNumarasi]);
                }
            }           
        }

        private void ButonKapat(string saat)
        {
            foreach (Button item in flp1.Controls)
            {
                if (item.Text == saat)
                {
                    item.Enabled = false;
                    item.BackColor = Color.DarkGray;
                }                   
            }
        }

        private void ButonDoldur()
        {
            flp1.Controls.Clear();
            for (int i = 0; i < Saatler.Count; i++)
            {
                Button randevuSaat = new Button()
                {
                    BackColor = Color.DarkGoldenrod,
                    Text = Saatler[i],
                    Name = "btnSaat_" + i,
                    Size = new Size(60, 30)
                };
                randevuSaat.Click += randevuSaat_Click;
                flp1.Controls.Add(randevuSaat);
            }
        }

        void randevuSaat_Click(object sender, EventArgs e)
        {
            SeciliButon = sender as Button;
            ButonuSec(SeciliButon);
        }

        private void ButonuSec(Button SeciliButon)
        {
            foreach (Button item in flp1.Controls)
            {
                if (item.Name == SeciliButon.Name)
                    SeciliButon.BackColor = Color.AliceBlue;
                else
                    item.BackColor = Color.DarkGoldenrod;
            }
            
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            secilenBirim = cmbBirim.SelectedItem as Birimler;
            Doktor secilenDoktor = cmbDoktor.SelectedItem as Doktor;

            try
            {
                var hastaRandevu = new RandevuRepo().GetAll().Where(x => x.HastaID == SeciliHasta.ID).ToList();

                foreach (var item in hastaRandevu)
                {
                    if (item.SiraNumarasi == Saatler.IndexOf(SeciliButon.Text) && item.RandevuZamani==dtpRandevuZamani.Value)
                    {
                        //MessageBox.Show("Hastanın " + SeciliButon.Text + " saatinde zaten bir randevusu bulunuyor");
                        throw new Exception("Hastanın " + SeciliButon.Text + " saatinde zaten bir randevusu bulunuyor");
                    }

                }

                Randevu eklenenRandevu = new Randevu();
                eklenenRandevu.BirimID = secilenBirim.ID;
                eklenenRandevu.DoktorID = secilenDoktor.ID;
                eklenenRandevu.HastaID = SeciliHasta.ID;
                eklenenRandevu.SiraNumarasi = Saatler.IndexOf(SeciliButon.Text);
                eklenenRandevu.RandevuZamani = dtpRandevuZamani.Value;

                new RandevuRepo().Insert(eklenenRandevu);
                MessageBox.Show("Randevunuz başarıyla eklenmiştir");

                lstListe.SelectedIndex = -1;
                cmbDoktor.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Henüz bir randevu seçmediniz");
            }
            
        }
        private void dtpRandevuZamani_ValueChanged(object sender, EventArgs e)
        {
            ButonDoldur();
            var randevular = new RandevuRepo().GetAll().Where(x => x.DoktorID != null && x.DoktorID == SeciliDoktor.ID && (x.RandevuZamani.Year == dtpRandevuZamani.Value.Year && x.RandevuZamani.Month == dtpRandevuZamani.Value.Month && x.RandevuZamani.Day == dtpRandevuZamani.Value.Day)).ToList();
            if (randevular.Count > 0)
            {
                foreach (var item in randevular)
                {
                    ButonKapat(Saatler[item.SiraNumarasi]);
                }
            }           
        }
    }
}
