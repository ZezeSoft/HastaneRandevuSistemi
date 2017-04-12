using RandevuSistemi.BLL;
using RandevuSistemi.Entity;
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
    public partial class frmDoktorListele : DoktorListelemeIntermediate
    {
        public frmDoktorListele()
        {
            InitializeComponent();
        }

        public List<Doktor> DoktorListesi { get; set; }
        private void frmDoktorListele_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ValueMember = "Cinsiyet";
            cmbCinsiyet.DataSource = new CinsiyetRepo().GetAll();

            cmbKanGrubu.ValueMember = "KanGrubu";
            cmbKanGrubu.DataSource = new KanGrubuRepo().GetAll();

            cmbBirim.ValueMember = "Birim";
            cmbBirim.DataSource = new BirimRepo().GetAll();

            cmbUnvan.ValueMember = "Unvan";
            cmbUnvan.DataSource = new UnvanRepo().GetAll();

            DoktorListesi = new DoktorRepo().GetAll();
            ListeyiDoldur(DoktorListesi);
        }

        private void ListeyiDoldur(List<Doktor> doktorListesi)
        {
            lstListe.ValueMember = "Ad" + "Soyad";
            lstListe.DataSource = doktorListesi;
        }

        public Doktor SeciliDoktor { get; set; }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeciliDoktor = lstListe.SelectedItem as Doktor;

            txtAd.Text = SeciliDoktor.Ad;
            txtSoyad.Text = SeciliDoktor.Soyad;
            txtTCKN.Text = SeciliDoktor.TCKN;
            dtpDogumTarihi.Value = SeciliDoktor.DogumTarihi;
            cmbCinsiyet.SelectedIndex = SeciliDoktor.CinsiyetID - 1;
            cmbKanGrubu.SelectedIndex = SeciliDoktor.KangrupID - 1;
            cmbBirim.SelectedIndex = SeciliDoktor.BirimID - 1;
            nMaas.Value = SeciliDoktor.Maas;
            cmbUnvan.SelectedIndex = SeciliDoktor.UnvanID - 1;

            var hemsireler = new HemsireRepo().GetAll().Where(x => x.DoktorID == SeciliDoktor.ID).ToList();

            clstHemsireler.Items.Clear();
            hemsireler.ForEach(x => clstHemsireler.Items.Add(x));

            for (int i = 0; i < clstHemsireler.Items.Count; i++)
            {
                clstHemsireler.SetItemChecked(i, true);
            }

            var atanmamisHemsireler = new HemsireRepo().GetAll().Where(x => x.DoktorID == null && x.BirimID == SeciliDoktor.BirimID).ToList();
            atanmamisHemsireler.ForEach(x => clstHemsireler.Items.Add(x));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SeciliDoktor.Ad = txtAd.Text;
                SeciliDoktor.Soyad = txtSoyad.Text;
                SeciliDoktor.TCKN = txtTCKN.Text;
                SeciliDoktor.DogumTarihi = dtpDogumTarihi.Value;
                SeciliDoktor.CinsiyetID = (cmbCinsiyet.SelectedItem as Cinsiyetler).ID;
                SeciliDoktor.KangrupID = (cmbKanGrubu.SelectedItem as KanGruplari).ID;
                SeciliDoktor.BirimID = (cmbBirim.SelectedItem as Birimler).ID;
                SeciliDoktor.Maas = nMaas.Value;
                SeciliDoktor.UnvanID = (cmbUnvan.SelectedItem as Unvanlar).ID;

                new DoktorRepo().Update();

                for (int i = 0; i < clstHemsireler.Items.Count; i++)
                {
                    if (clstHemsireler.GetItemCheckState(i) == CheckState.Checked)
                    {
                        Hemsire secilenHemsire = clstHemsireler.Items[i] as Hemsire;
                        if (secilenHemsire == null)
                        {
                            MessageBox.Show("Güncelleme işiniz gerçekleşti");
                            ListeyiDoldur(new DoktorRepo().GetAll());
                            return;
                        }
                        var sonuc = new HemsireRepo().GetAll().Where(x => x.ID == secilenHemsire.ID).FirstOrDefault();
                        sonuc.DoktorID = SeciliDoktor.ID;
                        new HemsireRepo().Update();
                    }
                    else if (clstHemsireler.GetItemCheckState(i) == CheckState.Unchecked)
                    {
                        Hemsire atanmamisHemsire = clstHemsireler.Items[i] as Hemsire;
                        var sonuc = new HemsireRepo().GetAll().Where(x => x.ID == atanmamisHemsire.ID).FirstOrDefault();
                        sonuc.DoktorID = null;
                        new HemsireRepo().Update();
                    }
                }

                MessageBox.Show("Güncelleme işiniz gerçekleşti");
                ListeyiDoldur(new DoktorRepo().GetAll());
            }
            catch (Exception)
            {

                MessageBox.Show("Güncellemek istediğiniz bilgileri giriniz");
            }

            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = new DoktorRepo().GetAll().Where(x=> x.ID==SeciliDoktor.ID).FirstOrDefault();
            var hemsire = new HemsireRepo().GetAll().Where(x => x.DoktorID == SeciliDoktor.ID).ToList();

            foreach (var item in hemsire)
            {
                item.DoktorID = null;
                new HemsireRepo().Update();
            }

            new DoktorRepo().Delete(sonuc);

            MessageBox.Show(SeciliDoktor.Ad+" "+SeciliDoktor.Soyad+" "+"isimli doktor sistemden silinmiştir");
            ListeyiDoldur(new DoktorRepo().GetAll());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {           
            ListeyiDoldur(DoktorRepo.Arama(txtAra.Text));

        }

    }
}
