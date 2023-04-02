namespace PedroFerrazeRuanPablo
{
    partial class frm_Posto
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtbox4 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(167, 297);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(114, 34);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(270, 119);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Digite a quantidade de litros: ";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(420, 116);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(109, 20);
            this.txtbox1.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(330, 297);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(114, 34);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(485, 297);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(114, 34);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(420, 153);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(109, 20);
            this.txtbox2.TabIndex = 6;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(197, 156);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(217, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Digite \"A\" para alcool ou \"G\" para gasolina: ";
            // 
            // txtbox4
            // 
            this.txtbox4.Enabled = false;
            this.txtbox4.Location = new System.Drawing.Point(420, 229);
            this.txtbox4.Name = "txtbox4";
            this.txtbox4.Size = new System.Drawing.Size(109, 20);
            this.txtbox4.TabIndex = 10;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(227, 232);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(187, 13);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "O valor total com o desconto sera de: ";
            // 
            // txtbox3
            // 
            this.txtbox3.Enabled = false;
            this.txtbox3.Location = new System.Drawing.Point(420, 192);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(109, 20);
            this.txtbox3.TabIndex = 8;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(267, 195);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(147, 13);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "O valor do desconto sera de: ";
            // 
            // frm_Posto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 457);
            this.Controls.Add(this.txtbox4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnvoltar);
            this.Name = "frm_Posto";
            this.Text = "frm_Posto";
            this.Load += new System.EventHandler(this.frm_Posto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtbox4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Label lbl3;
    }
}