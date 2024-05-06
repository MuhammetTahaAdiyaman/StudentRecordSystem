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

namespace OgrenciKayitSistemi
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TAHA\\SQLEXPRESS;Initial Catalog=OgrenciVeriTabani;Integrated Security=True;");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {   
            //toplam öğrenci sayısı
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Ogrenci", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label3.Text = dr1[0].ToString();
            }

            baglanti.Close();

            //aktif öğrenci sayısı

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Ogrenci Where OgrenciDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label4.Text = dr2[0].ToString();
            }

            baglanti.Close();

            //pasif öğrenci sayısı

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Ogrenci Where OgrenciDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label5.Text = dr3[0].ToString();
            }

            baglanti.Close();
        }
    }
}
