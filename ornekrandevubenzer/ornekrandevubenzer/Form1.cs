using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornekrandevubenzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap kitapp;
        List<Kitap> kitapListesi= new List<Kitap>();
        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListesi.Add(new Kitap(3, "Uzayda Yolculuk", "Zeynep Çetin", 265, "Roman", true, new DateTime(2023,11,30)));
            kitapListesi.Add(new Kitap(2, "Haydi Geziye", "İkra Deniz", 120, "Macera", false, new DateTime(2020,09, 20)));
            kitapListesi.Add(new Kitap(34, "Perili Köşk", "Gül Naz", 300, "Korku", true, new DateTime(1999, 12, 14)));
            kitapListesi.Add(new Kitap(8, "Kuyucaklı Yusuf", "Sabahattin Ali",290, "Roman", true, new DateTime(1992, 5, 26)));
            kitapListesi.Add(new Kitap(9, "Masal Masal İçinde", "Ahmet Ümit", 289, "Hikaye", false, new DateTime(2005, 8, 23)));
            kitapListesi.Add(new Kitap(78, "Çocuk Kalbi", "naz Demir", 620, "Roman", true, new DateTime(1983, 10, 29)));


            dgvListe.DataSource = kitapListesi;



        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            string kitapadı = txtKitapAdı.Text;
            string yazar= txtYazar.Text;
            int sayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
            string tur=cmbTur.Text;
            bool cilt=chkCilt.Checked;
            DateTime basimtarih=dtpBasimTarih.Value;

            Kitap yenikitap = new Kitap(id, kitapadı, yazar, sayfaSayisi , tur, cilt, basimtarih);

            kitapListesi.Add(yenikitap);
            dgvListe.DataSource=kitapListesi.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatır = dgvListe.SelectedRows[0];
            Kitap secilenKitap=secilenSatır.DataBoundItem as Kitap;
            DialogResult result = MessageBox.Show("Seçilen Kitap silinsin mi?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                kitapListesi.Remove(secilenKitap);
            }
            dgvListe.DataSource = kitapListesi.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

            Kitap secilenKitap = secilenSatir.DataBoundItem as Kitap;

            int id = Convert.ToInt32(txtId.Text);
            string kitapadı = txtKitapAdı.Text;
            string yazar = txtYazar.Text;
            int sayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
            string tur = cmbTur.Text;
            DateTime basimtarih = dtpBasimTarih.Value;
            bool cilt = chkCilt.Checked;


            secilenKitap.Id= id;
            secilenKitap.KitapAdı = kitapadı;
            secilenKitap.Yazar = yazar;
            secilenKitap. SayfaSayisi = sayfaSayisi;
            secilenKitap.Tur = tur;
            secilenKitap.Cilt = cilt;
            secilenKitap.BasimTarih = basimtarih;

            dgvListe.DataSource = null;
            dgvListe.DataSource = kitapListesi.ToList();





        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["Id"].Value.ToString();
            txtKitapAdı.Text = dgvListe.CurrentRow.Cells["kitapadı"].Value.ToString();
            txtYazar.Text = dgvListe.CurrentRow.Cells["yazar"].Value.ToString();
            txtSayfaSayisi.Text = dgvListe.CurrentRow.Cells["sayfaSayisi"].Value.ToString();
            cmbTur.Text = dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            dtpBasimTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["basimTarih"].Value;
        }
    }
}
