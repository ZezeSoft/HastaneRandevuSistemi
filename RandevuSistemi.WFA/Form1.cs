using RandevuSistemi.WFA.DoktorForm;
using RandevuSistemi.WFA.HastaForm;
using RandevuSistemi.WFA.HemsireForm;
using RandevuSistemi.WFA.PersonelForm;
using RandevuSistemi.WFA.RandevuForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemi.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        frmPersonelEkle personelEkleme;
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (personelEkleme == null || personelEkleme.IsDisposed)
                personelEkleme = new frmPersonelEkle();

            personelEkleme.Text = "Personel Ekleme Formu";
            personelEkleme.MdiParent = this;
            personelEkleme.Show();
        }

        frmPersonelListele personelListeleme;
        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (personelListeleme == null || personelListeleme.IsDisposed)
                personelListeleme = new frmPersonelListele();

            personelListeleme.Text = "Personel Listeleme Formu";
            personelListeleme.MdiParent = this;
            personelListeleme.Show();
        }

        frmHemsireEkle hemsireEkleme;
        private void hemşireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hemsireEkleme == null || hemsireEkleme.IsDisposed)
                hemsireEkleme = new frmHemsireEkle();

            hemsireEkleme.Text = "Hemsire Ekleme Formu";
            hemsireEkleme.MdiParent = this;
            hemsireEkleme.Show();
        }

        frmHemsireListele hemsireListele;
        private void hemşireDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hemsireListele == null || hemsireListele.IsDisposed)
                hemsireListele = new frmHemsireListele();

            hemsireListele.Text = "Hemsire Düzenleme Formu";
            hemsireListele.MdiParent = this;
            hemsireListele.Show();
        }

        frmDoktorEkle doktorEkleme;
        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doktorEkleme == null || doktorEkleme.IsDisposed)
                doktorEkleme = new frmDoktorEkle();

            doktorEkleme.Text = "Doktor Ekleme Formu";
            doktorEkleme.MdiParent = this;
            doktorEkleme.Show();
        }

        frmDoktorListele doktorDuzenleme;
        private void doktorDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doktorDuzenleme == null || doktorDuzenleme.IsDisposed)
                doktorDuzenleme = new frmDoktorListele();

            doktorDuzenleme.Text = "Doktor Duzenleme Formu";
            doktorDuzenleme.MdiParent = this;
            doktorDuzenleme.Show();
        }

        frmHastaEkle hastaEkleme;
        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hastaEkleme == null || hastaEkleme.IsDisposed)
                hastaEkleme = new frmHastaEkle();

            hastaEkleme.Text = "Hasta Ekleme Formu";
            hastaEkleme.MdiParent = this;
            hastaEkleme.Show();
        }

        frmHastaListele hastaDuzenleme;
        private void hastaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hastaDuzenleme == null || hastaDuzenleme.IsDisposed)
                hastaDuzenleme = new frmHastaListele();

            hastaDuzenleme.Text = "Hasta Duzenleme Formu";
            hastaDuzenleme.MdiParent = this;
            hastaDuzenleme.Show();
        }

        frmRandevuEkle randevuEkleme;
        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (randevuEkleme == null || randevuEkleme.IsDisposed)
                randevuEkleme = new frmRandevuEkle();

            randevuEkleme.Text = "Randevu Ekleme Formu";
            randevuEkleme.MdiParent = this;
            randevuEkleme.Show();
        }

        frmRandevuListele randevuListele;
        private void randevuListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (randevuListele == null || randevuListele.IsDisposed)
                randevuListele = new frmRandevuListele();

            randevuListele.Text = "Randevu Listeleme Formu";
            randevuListele.MdiParent = this;
            randevuListele.Show();
        }
    }
}
