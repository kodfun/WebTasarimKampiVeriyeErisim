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
    }
}
