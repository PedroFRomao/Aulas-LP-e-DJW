using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedroFerrazeRuanPablo
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void postoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Posto fm = new frm_Posto();
            fm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Loops fm = new frm_Loops();
            fm.Show();
        }

        private void eleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_votacao fm = new frm_votacao();
            fm.Show();
        }
    }
}
