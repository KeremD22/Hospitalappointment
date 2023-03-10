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
    public partial class Frmsekreterdetay : Form
    {
        public Frmsekreterdetay()
        {
            InitializeComponent();
        }
        public string Adsoy;
        public string TCnumara;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Frmsekreterdetay_Load(object sender, EventArgs e)
        {
            lbltcsekreter.Text= TCnumara;

            //ad soyad

            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltcsekreter.Text);
            SqlDataReader dr= komut.ExecuteReader(); 
            while(dr.Read())
            {
                label4.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            
            
            //Branşları datagride aktarma

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;

            //Doktorları datagride aktarma
            DataTable dt1= new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd + '' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource= dt1;

            //Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr3=komut2.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxskrtrdtybrans.Items.Add(dr3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void randevupnlkydt_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", maskedTextBoxskrtrdtytarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", maskedTextBoxskrtrdtysaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", comboBoxskrtrdtybrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", comboBoxskrtdtydoktro.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.");


        }

        private void comboBoxskrtrdtybrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxskrtdtydoktro.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxskrtrdtybrans.Text);
            SqlDataReader sqlDataReaderdr2= komut.ExecuteReader();
            while(sqlDataReaderdr2.Read())
            {
                comboBoxskrtdtydoktro.Items.Add(sqlDataReaderdr2[0].ToString() + sqlDataReaderdr2[1].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruoluştursekreter_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti() .Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btndoktorpanelisekreterdetay_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr=new FrmDoktorPaneli();
            fr.Show();
        }

        private void btnskrtrdetaybrans_Click(object sender, EventArgs e)
        {
            FrmBrans fr=new FrmBrans();
            fr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnrandevulstbtn_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void randevupnlgncl_Click(object sender, EventArgs e)
        {
            
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }
    }
}
