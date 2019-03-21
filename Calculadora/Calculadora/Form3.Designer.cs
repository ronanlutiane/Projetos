namespace Calculadora
{
    partial class Form3
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
            System.Windows.Forms.Button btnVoltar;
            System.Windows.Forms.Button btnSair;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVini = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.cboTempPrazo = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVfinal = new System.Windows.Forms.TextBox();
            this.cboTempTaxa = new System.Windows.Forms.ComboBox();
            btnVoltar = new System.Windows.Forms.Button();
            btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de Juros (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prazo";
            // 
            // txtVini
            // 
            this.txtVini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVini.Location = new System.Drawing.Point(174, 60);
            this.txtVini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVini.Name = "txtVini";
            this.txtVini.Size = new System.Drawing.Size(221, 26);
            this.txtVini.TabIndex = 3;
            // 
            // txtJuros
            // 
            this.txtJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.Location = new System.Drawing.Point(174, 103);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(221, 26);
            this.txtJuros.TabIndex = 4;
            // 
            // txtPrazo
            // 
            this.txtPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrazo.Location = new System.Drawing.Point(174, 148);
            this.txtPrazo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(221, 26);
            this.txtPrazo.TabIndex = 5;
            // 
            // cboTempPrazo
            // 
            this.cboTempPrazo.FormattingEnabled = true;
            this.cboTempPrazo.Items.AddRange(new object[] {
            "Ao mês",
            "Ao ano",
            "Ao dia"});
            this.cboTempPrazo.Location = new System.Drawing.Point(429, 148);
            this.cboTempPrazo.Name = "cboTempPrazo";
            this.cboTempPrazo.Size = new System.Drawing.Size(116, 28);
            this.cboTempPrazo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(46, 235);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 33);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(174, 235);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 33);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Final";
            // 
            // txtVfinal
            // 
            this.txtVfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVfinal.Location = new System.Drawing.Point(174, 192);
            this.txtVfinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVfinal.Name = "txtVfinal";
            this.txtVfinal.Size = new System.Drawing.Size(221, 26);
            this.txtVfinal.TabIndex = 10;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new System.Drawing.Point(309, 235);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new System.Drawing.Size(86, 33);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnSair
            // 
            btnSair.Location = new System.Drawing.Point(438, 235);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(86, 33);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // cboTempTaxa
            // 
            this.cboTempTaxa.FormattingEnabled = true;
            this.cboTempTaxa.Items.AddRange(new object[] {
            "Ao mês",
            "Ao ano",
            "Ao dia"});
            this.cboTempTaxa.Location = new System.Drawing.Point(429, 98);
            this.cboTempTaxa.Name = "cboTempTaxa";
            this.cboTempTaxa.Size = new System.Drawing.Size(116, 28);
            this.cboTempTaxa.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 301);
            this.Controls.Add(this.cboTempTaxa);
            this.Controls.Add(btnSair);
            this.Controls.Add(btnVoltar);
            this.Controls.Add(this.txtVfinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboTempPrazo);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtVini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVini;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.ComboBox cboTempPrazo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVfinal;
        private System.Windows.Forms.ComboBox cboTempTaxa;
    }
}