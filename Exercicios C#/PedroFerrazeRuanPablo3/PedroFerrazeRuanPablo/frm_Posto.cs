using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedroFerrazeRuanPablo
{
    public partial class frm_Posto : Form
    {
        public frm_Posto()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void frm_Posto_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            txtbox1.Clear();
            txtbox2.Clear();
            txtbox3.Clear();
            txtbox4.Clear();

            txtbox1.Focus();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double quant, des, pag;
            char comb;

            quant = Convert.ToDouble(txtbox1.Text);
            comb = Convert.ToChar(txtbox2.Text);

            if (comb == 'A')
            {
                if (quant <= 20)
                {
                    des = (4.9 * 0.03 * quant);
                    pag = (4.9 * quant - des);
                }
                else
                {
                    des = (4.9 * 0.05 * quant);
                    pag = (4.9 * quant - des);
                }
                txtbox3.Text = des.ToString();
                txtbox4.Text = pag.ToString();
            }
            else 
            {
                if (comb == 'G')
                {
                    if (quant <= 20)
                    {
                        des = (5.5 * 0.03 * quant);
                        pag = (5.5 * quant - des);
                    }
                    else
                    {
                        des = (5.5 * 0.05 * quant);
                        pag = (5.5 * quant - des);
                    }
                    txtbox3.Text = des.ToString();
                    txtbox4.Text = pag.ToString();
                }

            }
        }
    }
}
