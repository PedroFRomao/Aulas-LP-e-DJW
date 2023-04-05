namespace PedroFerrazeRuanPablo
{
    partial class frm_votacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl7 = new System.Windows.Forms.Label();
            this.btnvotar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(237, 281);
            this.lbl7.Name = "lbl7";
            this.lbl7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl7.Size = new System.Drawing.Size(330, 13);
            this.lbl7.TabIndex = 62;
            this.lbl7.Text = "Ele ganhou com uma diferença de NUMERO votos de CANDIDATO";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl7.Visible = false;
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // btnvotar
            // 
            this.btnvotar.Location = new System.Drawing.Point(353, 152);
            this.btnvotar.Name = "btnvotar";
            this.btnvotar.Size = new System.Drawing.Size(78, 23);
            this.btnvotar.TabIndex = 61;
            this.btnvotar.Text = "Votar";
            this.btnvotar.UseVisualStyleBackColor = true;
            this.btnvotar.Click += new System.EventHandler(this.btnvotar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(273, 89);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 13);
            this.lbl1.TabIndex = 60;
            this.lbl1.Text = "Digite 1 para votar em Maria: ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(277, 125);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(142, 13);
            this.lbl3.TabIndex = 59;
            this.lbl3.Text = "Digite 3 para votar em Jose: ";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(316, 252);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(168, 13);
            this.lbl6.TabIndex = 58;
            this.lbl6.Text = "Conquistou NUMERO% dos votos";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl6.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(261, 222);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(266, 13);
            this.lbl5.TabIndex = 57;
            this.lbl5.Text = "O ganhador da votação foi CANDIDATO com VOTOS ";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(341, 182);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(104, 13);
            this.lbl4.TabIndex = 56;
            this.lbl4.Text = "TEXTO RESPOSTA";
            this.lbl4.Visible = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(502, 327);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(114, 34);
            this.btnlimpar.TabIndex = 55;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(337, 327);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(114, 34);
            this.btncalcular.TabIndex = 54;
            this.btncalcular.Text = "Terminar Votação";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(426, 105);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(78, 20);
            this.txtbox1.TabIndex = 53;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(276, 107);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(143, 13);
            this.lbl2.TabIndex = 52;
            this.lbl2.Text = "Digite 2 para votar em João: ";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(184, 327);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(114, 34);
            this.btnvoltar.TabIndex = 51;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frm_votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.btnvotar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnvoltar);
            this.Name = "frm_votacao";
            this.Text = "frm_votacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Button btnvotar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnvoltar;
    }
}