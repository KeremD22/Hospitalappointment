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
    public partial class FrmuyeKayıt : Form
    {
        public FrmuyeKayıt()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmuyeKayıt_Load(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl=new sqlbaglantisi(); 
        private void kayıtol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", uyekayıtadtxt.Text);
            komut.Parameters.AddWithValue("@p2", uyekayıtsoyadtxt.Text);
            komut.Parameters.AddWithValue("@p3", uyekayıtTCtxt.Text);
            komut.Parameters.AddWithValue("@p4", uyekayıtTelefontxt.Text);
            komut.Parameters.AddWithValue("@p5", uyekayıtSifretxt.Text);
            komut.Parameters.AddWithValue("@p6", uyekayıtCombo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir Şifreniz:" + uyekayıtSifretxt.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void uyekayıtCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
