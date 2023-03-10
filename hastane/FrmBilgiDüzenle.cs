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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string Tcno;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            bilgidüzenleTCtxt.Text = Tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bilgidüzenleTCtxt);
            SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                bilgidüzenleadtxt.Text = dr[1].ToString();
                bilgidüzenlesoyadtxt.Text = dr[2].ToString();
                uyekayıtTelefontxt.Text = dr[4].ToString();
                bilgidüzenleSifretxt.Text = dr[5].ToString();
                bilgidüzenleCombo.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void buttonfrmbilgidüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", bilgidüzenleadtxt.Text);
            komut2.Parameters.AddWithValue("@p2", bilgidüzenlesoyadtxt.Text);
            komut2.Parameters.AddWithValue("@p3", uyekayıtTelefontxt.Text);
            komut2.Parameters.AddWithValue("@p4", bilgidüzenleSifretxt.Text);
            komut2.Parameters.AddWithValue("@p5", bilgidüzenleCombo.Text);
            komut2.Parameters.AddWithValue("@p6", bilgidüzenleTCtxt.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
