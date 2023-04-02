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

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num, i, res;
            i = 1;
            num = Convert.ToInt32(txtbox1.Text);
            while (i <= 10)
            {
                res = (i * num);
                txtbox2.AppendText($"{num} * {i} = {res}\r\n");
                i++;
            }
            txtbox1.Clear();
            txtbox1.Focus();
        }

        private void btncalcular2_Click(object sender, EventArgs e)
        {
            int num, i, res;
            i = 1;
            num = Convert.ToInt32(txtbox1.Text);
            do
            {
                res = (i * num);
                txtbox3.AppendText($"{num} * {i} = {res}\r\n");
                i++;
            } while (i <= 10);
            txtbox1.Clear();
            txtbox1.Focus();
        }

        private void btncalcular3_Click(object sender, EventArgs e)
        {
            int num, i, res;
            num = Convert.ToInt32(txtbox1.Text);
            for (i = 1; i <= 10; i++)
            {
                res = (i * num);
                txtbox4.AppendText($"{num} * {i} = {res}\r\n");
            }
            txtbox1.Clear();
            txtbox1.Focus();
        }


        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbox1.Clear();
            txtbox2.Clear();
            txtbox3.Clear();
            txtbox4.Clear();

            txtbox1.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
