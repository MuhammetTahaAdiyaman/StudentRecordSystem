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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1-ilk önce sql baglantisini yapmamız gerekmektedir.
        SqlConnection baglanti = new SqlConnection("Data Source=TAHA\\SQLEXPRESS;Initial Catalog=OgrenciVeriTabani;Integrated Security=True;");
        
        private void temizle()
        {
            TxtOgrenciId.Text = "";
            TxtOgrenciAd.Text = "";
            TxtOgrenciSoyad.Text = "";
            MskOgrenciNo.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_OgrenciTableAdapter.Fill(this.ogrenciVeriTabaniDataSet.Tbl_Ogrenci);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //2-sql baglantimizi açıp kapatmamız gerekmektedir daha sonra sql command (komutu) yazmamız gerekmektedir.
            baglanti.Open();
            //3-sql komutu yazmamız için bir nesne oluşturmamız gerekmektedir.
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Ogrenci (OgrenciNo,OgrenciAd,OgrenciSoyad,OgrenciDurum) values (@p1,@p2,@p3,@p4)",baglanti);
            //4-verdiğimiz parametreleri eklememiz gerekmektedir.
            komut1.Parameters.AddWithValue("@p1", MskOgrenciNo.Text);
            komut1.Parameters.AddWithValue("@p2", TxtOgrenciAd.Text);
            komut1.Parameters.AddWithValue("@p3",TxtOgrenciSoyad.Text);
            //5-radio button için aşağıda bulunan radiobutton için yazdığımız komutlarda mantığı anlarsın label1 e göre hareket ettirdik.
            komut1.Parameters.AddWithValue("@p4", label1.Text);
            //6-bizim komutumuzun çalışması için nonquery eklentisini yapmamız gerek. Ancak bu eklenti UPDATE,DELETE,INSERT işlemi için geçerlidir. Select işlemi için başka bir eklenti yapacağız.
            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Eklendi","Eklendi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label1.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                label1.Text = "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            //7-temizlemek için kolay bir yöntem var. Hemen temizle metodu oluşturalım ve burada çağıralım.
            temizle();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   //8-seçilen satır hücresini araçlara taşıma işlemini yapıyoruz. grid view de çift tıklayınca bilgiler yukarı taşınacak.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtOgrenciId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskOgrenciNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtOgrenciAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtOgrenciSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); //radio buton için aşağıdaki kodlar geçerli olacak.
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if(label1.Text == "True")
            {
                radioButton1.Checked = true;
            }

            if(label1.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {   //9-ogrenci silme işlemini yapıyoruz aynı insert işlemine benzer şekilde
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Delete From Tbl_Ogrenci Where OgrenciId = @d1 ", baglanti);
            komut2.Parameters.AddWithValue("@d1", TxtOgrenciId.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Silindi","Öğrenci Silme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //10-öğrenci güncelleme işlemini yapıyoruz aynı insert delete işlemine benzer şekilde.
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Update Tbl_Ogrenci Set OgrenciNo=@g1,OgrenciAd=@g2,OgrenciSoyad=@g3,OgrenciDurum=@g4 where OgrenciId = @g5", baglanti);
            komut3.Parameters.AddWithValue("@g1", MskOgrenciNo.Text);
            komut3.Parameters.AddWithValue("@g2", TxtOgrenciAd.Text);
            komut3.Parameters.AddWithValue("@g3", TxtOgrenciSoyad.Text);
            komut3.Parameters.AddWithValue("@g4", label1.Text);
            komut3.Parameters.AddWithValue("@g5", TxtOgrenciId.Text);
            komut3.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Ogrenci Guncellendi","Ogrenci Güncelleme İşlemi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
