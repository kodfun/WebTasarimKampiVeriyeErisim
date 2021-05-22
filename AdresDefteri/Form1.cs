using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdresDefteri
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=AdresDefteriDb; Trusted_Connection=True;");

        // form oluşturulurken ilk çalışan metot (constructor metod)
        public Form1()
        {
            con.Open();
            InitializeComponent();
            VerileriListele();
        }

        private void VerileriListele()
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, Ad, Soyad, Telefon, Adres FROM Adresler", con);
            SqlDataReader dr = cmd.ExecuteReader();

            dgvAdresler.Rows.Clear(); // önce tüm satırları silelim (varsa)
            while (dr.Read())
            {
                dgvAdresler.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            dr.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Adresler (Ad, Soyad, Telefon, Adres) VALUES(@p1, @p2, @p3, @p4)", con);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@p4", txtAdres.Text);
            int etkilenenSatirSayisi = cmd.ExecuteNonQuery();

            FormuSifirla();
            VerileriListele();
        }

        private void FormuSifirla()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAdresler.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow satir in dgvAdresler.SelectedRows)
                {
                    var cmd = new SqlCommand("DELETE FROM Adresler WHERE Id = @p1", con);
                    cmd.Parameters.AddWithValue("@p1", (int)satir.Cells[0].Value);
                    int sonuc = cmd.ExecuteNonQuery();
                }
                VerileriListele();
            }
        }
    }
}
