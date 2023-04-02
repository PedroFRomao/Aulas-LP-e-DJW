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
    public partial class frm_votacao : Form
    {
        public frm_votacao()
        {
            InitializeComponent();
        }

        private void btnvotar_Click(object sender, EventArgs e)
        {
            double voto, c1, c2, c3, i;
            voto = Convert.ToDouble(txtbox1.Text);
            c1 = 0;
            c2 = 0;
            c3 = 0;
            i = 0;

            if (voto == 1)
            {
                c1 = c1 + 1;
                i = i + 1;
                lbl4.Text = "Voto1 confirmado";
                lbl4.Visible = true;

            }
            else
            {
                if (voto == 2)
                {
                    c2 = c2 + 1;
                    i = i + 1;
                    lbl4.Text = "Voto2 confirmado";
                    lbl4.Visible = true;

                }
                else
                {
                    if (voto == 3)
                    {
                        c3 = c3 + 1;
                        i = i + 1;
                        lbl4.Text = "Voto3 confirmado";
                        lbl4.Visible = true;

                    }
                    else
                    {
                        lbl4.Text = "ERROR";
                        lbl4.Visible = true;

                    }
                }
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
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

            txtbox1.Focus();
        }
    }
}
