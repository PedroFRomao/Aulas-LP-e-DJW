using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PedroFerrazeRuanPablo
{
    public partial class frm_Loops : Form
    {
        public frm_Loops()
        {
            InitializeComponent();
        }

        private void frm_Loops_Load(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbox1.Clear();
            txtbox2.Clear();

            txtbox1.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num, i, res;
            i = 0;
            num = Convert.ToInt32(txtbox1.Text);
            while (i <= 10){
                res = (i * num);
                txtbox2.Text = res.ToString();
                i = i + 1;
            }
        }

        private void btncalcular3_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular2_Click(object sender, EventArgs e)
        {

        }
    }
}
