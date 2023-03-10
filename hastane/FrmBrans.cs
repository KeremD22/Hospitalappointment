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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();  
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * From Tbl_Brans",bgl.baglanti());
            da.Fill(dt);
            bransdatagrid.DataSource= dt;
        }

        private void bransekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("insert into Tbl_Brans (BransAd) values (@b1) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", bransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bransdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = bransdatagrid.SelectedCells[0].RowIndex;
            bransid.Text = bransdatagrid.Rows[secilen].Cells[0].Value.ToString();
            bransad.Text = bransdatagrid.Rows[secilen].Cells[1].Value.ToString();
        }

        private void branssil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From tbl_branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", bransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi.");

        }

        private void bransgüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_branslar set bransad=@p1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransad.Text);
            komut.Parameters.AddWithValue("@p2", bransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş güncellendi.");
        }  
    }
}
