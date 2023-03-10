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
    public partial class FrmSekreterGrs : Form
    {
        public FrmSekreterGrs()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi(); 
        private void sekretergrsbutton_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sekretergrstxt.Text);
            komut.Parameters.AddWithValue("@p2", sekretergrssfretxt.Text);
            SqlDataReader dataReader= komut.ExecuteReader();
             if(dataReader.Read())
            {
                Frmsekreterdetay frs = new Frmsekreterdetay();
              
                frs.TCnumara = label2.Text;
                frs.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
         
            }
            bgl.baglanti().Close();
        }

        private void sekretergrstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
