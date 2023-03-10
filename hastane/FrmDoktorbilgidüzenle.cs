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
namespace hastane
{
    public partial class FrmDoktorbilgidüzenle : Form
    {
        public FrmDoktorbilgidüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TCNO;
        private void label1_Click(object sender, EventArgs e)
        {
           
               
        }

        private void FrmDoktorbilgidüzenle_Load(object sender, EventArgs e)
        {
            bilgidüzenleTCtxt.Text = TCNO;
            SqlCommand komut=new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label2.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read()) {
                bilgidüzenleadtxtdoktor.Text = dr[1].ToString();
                bilgidüzenletxtdoktor.Text = dr[2].ToString(); 
                bilgidüzenleCombodoktor.Text = dr[3].ToString();    
                bilgidüzenleSifretxt.Text= dr[5].ToString();
            }
            bgl.baglanti().Close();


        }

        private void buttonfrmbilgidüzenledoktor_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktolar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bilgidüzenleadtxtdoktor.Text);
            komut.Parameters.AddWithValue("@p2", bilgidüzenletxtdoktor.Text);
            komut.Parameters.AddWithValue("@p3", bilgidüzenleCombodoktor.Text);
            komut.Parameters.AddWithValue("@p4", bilgidüzenleSifretxt.Text);
            komut.Parameters.AddWithValue("@p5", label2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");


        }
    }
}
