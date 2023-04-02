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

        public static class GlobalVariables
        {
            public static int c1;
            public static int c2;
            public static int c3;
            public static int i;
        }

        private void btnvotar_Click(object sender, EventArgs e)
        {
            int c1 = GlobalVariables.c1;
            int c2 = GlobalVariables.c2;
            int c3 = GlobalVariables.c3;
            int i = GlobalVariables.i;

            double voto;
            voto = Convert.ToInt32(txtbox1.Text);

            GlobalVariables.c1 = 0;
            GlobalVariables.c2 = 0;
            GlobalVariables.c3 = 0;
            GlobalVariables.i = 0;

            if (voto == 1)
            {
                c1++;
                i++;
                lbl4.Text = "Voto1 confirmado";
                lbl4.Visible = true;
                txtbox1.Clear();
                txtbox1.Focus();
                voto = 0;

            }
            else
            {
                if (voto == 2)
                {
                    c2++;
                    i++;
                    lbl4.Text = "Voto2 confirmado";
                    lbl4.Visible = true;
                    txtbox1.Clear();
                    txtbox1.Focus();
                    voto = 0;

                }
                else
                {
                    if (voto == 3)
                    {
                        c3++;
                        i++;
                        lbl4.Text = "Voto3 confirmado";
                        lbl4.Visible = true;
                        txtbox1.Clear();
                        txtbox1.Focus();
                        voto = 0;

                    }
                    else
                    {
                        lbl4.Text = "ERROR";
                        lbl4.Visible = true;
                        txtbox1.Clear();
                        txtbox1.Focus();
                        voto = 0;

                    }
                }
            }
            GlobalVariables.c1 = c1;
            GlobalVariables.c2 = c2;
            GlobalVariables.c3 = c3;
            GlobalVariables.i = i;

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int c1 = GlobalVariables.c1;
            int c2 = GlobalVariables.c2;
            int c3 = GlobalVariables.c3;
            int i = GlobalVariables.i;

            if ((c1 > c2) && (c1 > c3))
            {
                lbl5.Text = $"A Maria foi a vencedora com {c1} ponto(s)";
                lbl6.Text = $"Ela conquistou {(c1 * 100.0 / i):0.00} % dos votos";
                if (c2 + c3 == 0)
                {
                    lbl7.Text = "Ela ganhou invicta";
                }
                else
                {
                    if (c2 > c3)
                    {
                        lbl7.Text = $"Ela ganhou com uma diferenca de {c1 - c2} votos de Joao";
                    }
                    else
                    {
                        lbl7.Text = $"Ela ganhou com uma diferenca de {c1 - c3} votos de Jose";
                    }
                }
            }
            else
            {
                if ((c2 > c1) && (c2 > c3))
                {
                    lbl5.Text = $"O Joao foi o vencedor com {c2} ponto(s)";
                    lbl6.Text = $"Ele conquistou {(c2 * 100.0 / i):0.00} % dos votos";
                    if (c1 + c3 == 0)
                    {
                        lbl7.Text = "Ele ganhou invicto";
                    }
                    else
                    {
                        if (c1 > c3)
                        {
                            lbl7.Text = $"Ele ganhou com uma diferenca de {c2 - c1} votos de Maria";
                        }
                        else
                        {
                            lbl7.Text = $"Ele ganhou com uma diferenca de {c2 - c3} votos de Jose";
                        }
                    }
                }
                else
                {
                    if ((c3 > c1) && (c3 > c2))
                    {
                        lbl5.Text = $"O Jose foi o vencedor com {c3} ponto(s)";
                        lbl6.Text = $"Ele conquistou {(c3 * 100.0 / i):0.00} % dos votos";
                        if (c1 + c2 == 0)
                        {
                            lbl7.Text = "Ele ganhou invicto";
                        }
                        else
                        {
                            if (c2 > c1)
                            {
                                lbl7.Text = $"Ele ganhou com uma diferenca de {c3 - c2} votos de Joao";
                            }
                            else
                            {
                                lbl7.Text = $"Ele ganhou com uma diferenca de {c3 - c1} votos de Maria";
                            }
                        }
                    }
                    else
                    {
                        lbl5.Text = "Ouve um empate entre dois candidatos";
                        if (c1 == c2)
                        {
                            lbl6.Text = $"Os candidatos Maria e Joao empataram com {c1} voto(s)";
                        }
                        else
                        {
                            if (c1 == c3)
                            {
                                lbl6.Text = $"Os candidatos Maria e Jose empataram com {c1} voto(s)";
                            }
                            else
                            {
                                if (c2 == c3)
                                {
                                    lbl6.Text = $"Os candidatos Jose e Joao empataram com {c2} voto(s)";
                                }
                                else
                                {
                                    lbl6.Text = "ERROR";
                                }
                            }
                        }
                    }
                }
            }
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
            GlobalVariables.c1 = 0;
            GlobalVariables.c2 = 0;
            GlobalVariables.c3 = 0;
            GlobalVariables.i = 0;

            txtbox1.Focus();
        }
    }
}
