using AdresDefteriEf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdresDefteriEf
{
    public partial class Form1 : Form
    {
        AdresDefteriContext _db = new AdresDefteriContext();
        Kisi _duzenlenenKisi = null;

        public Form1()
        {
            InitializeComponent();
            VerileriListele();
        }

        private void VerileriListele()
        {
            string ara = txtAra.Text;
            if (ara == "")
            {
                dgvKisiler.DataSource = _db.Kisiler.ToList();
            }
            else
            {
                dgvKisiler.DataSource =
                    _db.Kisiler
                        .Where(k => k.Ad.Contains(ara) 
                            || k.Soyad.Contains(ara) 
                            || k.Telefon.Contains(ara) 
                            || k.Adres.Contains(ara)
                            || k.Id.ToString() == ara)
                        .ToList();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_duzenlenenKisi == null)
            {
                Kisi kisi = new Kisi()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Adres = txtAdres.Text
                };
                _db.Kisiler.Add(kisi);
            }
            else
            {
                _duzenlenenKisi.Ad = txtAd.Text;
                _duzenlenenKisi.Soyad = txtSoyad.Text;
                _duzenlenenKisi.Telefon = txtTelefon.Text;
                _duzenlenenKisi.Adres = txtAdres.Text;
            }
            FormuSifirla();
            _db.SaveChanges();
            VerileriListele();
        }

        private void FormuSifirla()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            btnEkle.Text = "Ekle";
            btnIptal.Hide();
            _duzenlenenKisi = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKisiler.SelectedRows.Count > 0)
            {
                DataGridViewRow satir = dgvKisiler.SelectedRows[0];
                Kisi kisi = (Kisi)satir.DataBoundItem;
                _db.Kisiler.Remove(kisi);
                _db.SaveChanges();
                VerileriListele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvKisiler.SelectedRows.Count > 0)
            {
                DataGridViewRow satir = dgvKisiler.SelectedRows[0];
                _duzenlenenKisi = (Kisi)satir.DataBoundItem;
                txtAd.Text = _duzenlenenKisi.Ad;
                txtSoyad.Text = _duzenlenenKisi.Soyad;
                txtTelefon.Text = _duzenlenenKisi.Telefon;
                txtAdres.Text = _duzenlenenKisi.Adres;
                btnEkle.Text = "Kaydet";
                btnIptal.Show();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuSifirla();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            VerileriListele();
        }
    }
}
