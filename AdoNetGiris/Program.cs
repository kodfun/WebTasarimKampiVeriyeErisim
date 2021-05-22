using System;
using System.Data.SqlClient;

namespace AdoNetGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ADIM: BAĞLANTI KURULMASI
            SqlConnection con = 
                new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=GirisDb; Integrated Security=True;");

            con.Open(); // bağlantımızı açtık

            // 2. ADIM: KOMUT NESNESİ OLUŞTURULMASI
            SqlCommand cmd = new SqlCommand("SELECT Id, SehirAd FROM Sehirler", con);

            // 3. ADIM: KOMUTUN ÇALIŞTIRILMASI VE VERİ OKUYUCUNUN OLUŞTURULMASI/ATANMASI
            SqlDataReader dr = cmd.ExecuteReader();

            // 4. ADIM: VERİLERİN SATIR SATIR OKUNMASI
            while (dr.Read())
            {
                //Console.WriteLine("{0} {1}", dr[0], dr[1]);
                Console.WriteLine("{0} {1}", dr["Id"], dr["SehirAd"]);
            }

            dr.Close();

            // 5. ADIM: BAĞLANTININ KAPATILMASI
            con.Close();


            Console.ReadKey();
        }
    }
}
