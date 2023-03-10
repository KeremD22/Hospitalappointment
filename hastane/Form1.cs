using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDktGrs_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş fr = new FrmDoktorGiriş();
            fr.Show();
            this.Hide();
        }

        private void BtnHastaGrs_Click(object sender, EventArgs e)
        {
            FrmHastagiris fr = new FrmHastagiris();
            fr.Show();
            this.Hide();

        }

        private void BtnSekreterGrs_Click(object sender, EventArgs e)
        {
            FrmSekreterGrs fr=new FrmSekreterGrs();
            fr.Show();
            this.Hide();    
        }
    }
}
