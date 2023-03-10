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
    public partial class FrmHastagiris : Form
    {
        public FrmHastagiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmuyeKayıt fr=new FrmuyeKayıt();
            fr.Show();  
        }

        private void FrmHastagiris_Load(object sender, EventArgs e)
        {

        }

        private void Hastagrsbtn_Click(object sender, EventArgs e)
        {
         
           SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hstgrstxt);
            komut.Parameters.AddWithValue("@p2", hstgrssfretxt);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr=new  FrmHastaDetay();
                fr.tc = hstgrstxt.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }

        
        
        }
    }
}
