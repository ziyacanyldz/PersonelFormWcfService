using PersonelManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonelForm
{
    public partial class Form1 : Form
    {
        private void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMaas.Text = "";
            txtSehir.Text = "";
            txtMeslek.Text = "";
            txtTelNo.Text = "";

        }


        private void KayitlariGetir()
        {
            PersonelManager personelManager = new PersonelManager();
            dataGridView1.DataSource = personelManager.GetirHepsi();


            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[1].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[2].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[3].Width = 45;
            dataGridView1.Columns[3].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[5].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[6].Resizable = DataGridViewTriState.False;
        }


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            KayitlariGetir();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelService.PersonelServiceClient serviceClient = new PersonelService.PersonelServiceClient();
            PersonelForm.PersonelService.Personel personel = new PersonelForm.PersonelService.Personel(); 

            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.Maas = txtMaas.Text;
            personel.Sehir = txtSehir.Text;
            personel.Meslek = txtMeslek.Text;
            personel.TelNo = txtTelNo.Text;

            serviceClient.Add(personel);
            txtMesaj.Text = "Personel eklendi";
            KayitlariGetir();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PersonelService.PersonelServiceClient serviceClient = new PersonelService.PersonelServiceClient();
            PersonelForm.PersonelService.Personel personel = new PersonelForm.PersonelService.Personel(); 

            personel.Id = Convert.ToInt32(txtId.Text);

            if (serviceClient.Delete(personel.Id))
            {
                txtMesaj.Text = "Personel silindi";
                temizle();
                KayitlariGetir();
            }
            else
            {
                txtMesaj.Text = "Personel silinemedi , tekrar deneyin";
                temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PersonelService.PersonelServiceClient serviceClient = new PersonelService.PersonelServiceClient();
            PersonelForm.PersonelService.Personel personel = new PersonelForm.PersonelService.Personel(); 

            personel.Id = Convert.ToInt32(txtId.Text);
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.Maas = txtMaas.Text;
            personel.Sehir = txtSehir.Text;
            personel.Meslek = txtMeslek.Text;
            personel.TelNo = txtTelNo.Text;

            if (serviceClient.Update(personel))
            {
                txtMesaj.Text = "Personel güncellendi";
                temizle();
                KayitlariGetir();
            }
            else
            {
                txtMesaj.Text = "Personel güncellenemedi , tekrar deneyin";
                temizle();
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            PersonelService.PersonelServiceClient serviceClient = new PersonelService.PersonelServiceClient();
            PersonelForm.PersonelService.Personel personel = new PersonelForm.PersonelService.Personel();

            personel = serviceClient.GetById(Convert.ToInt32(txtId.Text));

            if (personel.Ad != null)
            {
                txtAd.Text = personel.Ad;
                txtSoyad.Text = personel.Soyad;
                txtMaas.Text = personel.Maas;
                txtSehir.Text = personel.Sehir;
                txtMeslek.Text = personel.Meslek;
                txtTelNo.Text = personel.TelNo;

                txtMesaj.Text = "Kayıt getirildi";
            }
            else
            {
                txtMesaj.Text = "Bu id ile bir kayıt bulunamadı";
                temizle();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            txtSehir.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txtTelNo.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
