namespace PedroFerrazeRuanPablo
{
    partial class frm_Loops
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
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncalcular3 = new System.Windows.Forms.Button();
            this.btncalcular2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(470, 139);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(109, 20);
            this.txtbox2.TabIndex = 17;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(247, 142);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(217, 13);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "Digite \"A\" para alcool ou \"G\" para gasolina: ";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(36, 303);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(114, 34);
            this.btnlimpar.TabIndex = 15;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(36, 142);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(114, 34);
            this.btncalcular.TabIndex = 14;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(470, 102);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(109, 20);
            this.txtbox1.TabIndex = 13;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(369, 105);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(95, 13);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Digite um numero: ";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(36, 86);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(114, 34);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncalcular3
            // 
            this.btncalcular3.Location = new System.Drawing.Point(36, 251);
            this.btncalcular3.Name = "btncalcular3";
            this.btncalcular3.Size = new System.Drawing.Size(114, 34);
            this.btncalcular3.TabIndex = 18;
            this.btncalcular3.Text = "Calcular";
            this.btncalcular3.UseVisualStyleBackColor = true;
            // 
            // btncalcular2
            // 
            this.btncalcular2.Location = new System.Drawing.Point(36, 198);
            this.btncalcular2.Name = "btncalcular2";
            this.btncalcular2.Size = new System.Drawing.Size(114, 34);
            this.btncalcular2.TabIndex = 19;
            this.btncalcular2.Text = "Calcular";
            this.btncalcular2.UseVisualStyleBackColor = true;
            // 
            // frm_Loops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular2);
            this.Controls.Add(this.btncalcular3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnvoltar);
            this.Name = "frm_Loops";
            this.Text = "frm_Loops";
            this.Load += new System.EventHandler(this.frm_Loops_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncalcular3;
        private System.Windows.Forms.Button btncalcular2;
    }
}