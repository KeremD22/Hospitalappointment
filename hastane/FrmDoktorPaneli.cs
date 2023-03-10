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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //Doktorları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxdktrpnlbrans.Items.Add(dr3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", doktorpanelitxtad.Text);
            komut.Parameters.AddWithValue("@d2", soyaddoktorpanelitxt.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxdktrpnlbrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBoxdktrpnltc.Text);
            komut.Parameters.AddWithValue("@d5", textBoxdktrpnlsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxdktrpnltc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            doktorpanelitxtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyaddoktorpanelitxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            comboBoxdktrpnlbrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            maskedTextBoxdktrpnltc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxdktrpnlsifre.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorTC=@d4,DoktorSifre=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", doktorpanelitxtad.Text);
            komut.Parameters.AddWithValue("@d2", soyaddoktorpanelitxt.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxdktrpnlbrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBoxdktrpnltc.Text);
            komut.Parameters.AddWithValue("@d5", textBoxdktrpnlsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
