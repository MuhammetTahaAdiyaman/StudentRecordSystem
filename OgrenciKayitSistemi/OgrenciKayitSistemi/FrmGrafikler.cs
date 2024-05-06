using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OgrenciKayitSistemi
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TAHA\\SQLEXPRESS;Initial Catalog=OgrenciVeriTabani;Integrated Security=True;");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select OgrenciDurum, Count(*) From Tbl_Ogrenci Group By OgrenciDurum",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Pasif"].Points.AddXY(dr1[0],dr1[1]);
                chart1.Series["Aktif"].Points.AddXY(dr1[0],dr1[1]);
            }
            baglanti.Close();
        }
    }
}
