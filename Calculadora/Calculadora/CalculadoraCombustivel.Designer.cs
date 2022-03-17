namespace Calculadora
{
    partial class frmCalcularCombustivel
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblOrientacao = new System.Windows.Forms.Label();
            this.lblValorDoCombustivel = new System.Windows.Forms.Label();
            this.txtValorCombustivel = new System.Windows.Forms.TextBox();
            this.lblTipoCombustível = new System.Windows.Forms.Label();
            this.lstTipoCombustível = new System.Windows.Forms.ListBox();
            this.lblConsumoMedio = new System.Windows.Forms.Label();
            this.txtConsumoMedio = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.chkIdaVolta = new System.Windows.Forms.CheckBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultadoCombustivel = new System.Windows.Forms.TextBox();
            this.lblCombustivelConsumir = new System.Windows.Forms.Label();
            this.lblCustoEstimado = new System.Windows.Forms.Label();
            this.txtResultadoValor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(211, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 38);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblOrientacao
            // 
            this.lblOrientacao.AutoSize = true;
            this.lblOrientacao.Location = new System.Drawing.Point(39, 37);
            this.lblOrientacao.Name = "lblOrientacao";
            this.lblOrientacao.Size = new System.Drawing.Size(219, 13);
            this.lblOrientacao.TabIndex = 1;
            this.lblOrientacao.Text = "Informe os dados abaixo e clique em calcular";
            // 
            // lblValorDoCombustivel
            // 
            this.lblValorDoCombustivel.AutoSize = true;
            this.lblValorDoCombustivel.Location = new System.Drawing.Point(39, 81);
            this.lblValorDoCombustivel.Name = "lblValorDoCombustivel";
            this.lblValorDoCombustivel.Size = new System.Drawing.Size(108, 13);
            this.lblValorDoCombustivel.TabIndex = 2;
            this.lblValorDoCombustivel.Text = "Valor do Combustível";
            // 
            // txtValorCombustivel
            // 
            this.txtValorCombustivel.BackColor = System.Drawing.Color.LightGray;
            this.txtValorCombustivel.Location = new System.Drawing.Point(156, 77);
            this.txtValorCombustivel.Name = "txtValorCombustivel";
            this.txtValorCombustivel.Size = new System.Drawing.Size(100, 20);
            this.txtValorCombustivel.TabIndex = 3;
            // 
            // lblTipoCombustível
            // 
            this.lblTipoCombustível.AutoSize = true;
            this.lblTipoCombustível.Location = new System.Drawing.Point(286, 80);
            this.lblTipoCombustível.Name = "lblTipoCombustível";
            this.lblTipoCombustível.Size = new System.Drawing.Size(105, 13);
            this.lblTipoCombustível.TabIndex = 4;
            this.lblTipoCombustível.Text = "Tipo de Combustível";
            // 
            // lstTipoCombustível
            // 
            this.lstTipoCombustível.BackColor = System.Drawing.Color.LightGray;
            this.lstTipoCombustível.FormattingEnabled = true;
            this.lstTipoCombustível.Location = new System.Drawing.Point(397, 77);
            this.lstTipoCombustível.Name = "lstTipoCombustível";
            this.lstTipoCombustível.Size = new System.Drawing.Size(120, 17);
            this.lstTipoCombustível.TabIndex = 5;
            // 
            // lblConsumoMedio
            // 
            this.lblConsumoMedio.AutoSize = true;
            this.lblConsumoMedio.Location = new System.Drawing.Point(39, 123);
            this.lblConsumoMedio.Name = "lblConsumoMedio";
            this.lblConsumoMedio.Size = new System.Drawing.Size(160, 13);
            this.lblConsumoMedio.TabIndex = 6;
            this.lblConsumoMedio.Text = "Consumo médio do carro (KM/L)";
            // 
            // txtConsumoMedio
            // 
            this.txtConsumoMedio.BackColor = System.Drawing.Color.LightGray;
            this.txtConsumoMedio.Location = new System.Drawing.Point(211, 120);
            this.txtConsumoMedio.Name = "txtConsumoMedio";
            this.txtConsumoMedio.Size = new System.Drawing.Size(100, 20);
            this.txtConsumoMedio.TabIndex = 7;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(335, 123);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(127, 13);
            this.lblDistancia.TabIndex = 8;
            this.lblDistancia.Text = "Distância a ser percorrida";
            // 
            // chkIdaVolta
            // 
            this.chkIdaVolta.AutoSize = true;
            this.chkIdaVolta.Location = new System.Drawing.Point(552, 79);
            this.chkIdaVolta.Name = "chkIdaVolta";
            this.chkIdaVolta.Size = new System.Drawing.Size(117, 17);
            this.chkIdaVolta.TabIndex = 9;
            this.chkIdaVolta.Text = "Calcular Ida e volta";
            this.chkIdaVolta.UseVisualStyleBackColor = true;
            // 
            // txtDistancia
            // 
            this.txtDistancia.BackColor = System.Drawing.Color.LightGray;
            this.txtDistancia.Location = new System.Drawing.Point(468, 120);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(39, 162);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(66, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultados: ";
            // 
            // txtResultadoCombustivel
            // 
            this.txtResultadoCombustivel.BackColor = System.Drawing.Color.LightGray;
            this.txtResultadoCombustivel.Location = new System.Drawing.Point(42, 217);
            this.txtResultadoCombustivel.Name = "txtResultadoCombustivel";
            this.txtResultadoCombustivel.Size = new System.Drawing.Size(216, 20);
            this.txtResultadoCombustivel.TabIndex = 12;
            // 
            // lblCombustivelConsumir
            // 
            this.lblCombustivelConsumir.AutoSize = true;
            this.lblCombustivelConsumir.Location = new System.Drawing.Point(42, 189);
            this.lblCombustivelConsumir.Name = "lblCombustivelConsumir";
            this.lblCombustivelConsumir.Size = new System.Drawing.Size(118, 13);
            this.lblCombustivelConsumir.TabIndex = 13;
            this.lblCombustivelConsumir.Text = "Combustivel a consumir";
            // 
            // lblCustoEstimado
            // 
            this.lblCustoEstimado.AutoSize = true;
            this.lblCustoEstimado.Location = new System.Drawing.Point(397, 189);
            this.lblCustoEstimado.Name = "lblCustoEstimado";
            this.lblCustoEstimado.Size = new System.Drawing.Size(120, 13);
            this.lblCustoEstimado.TabIndex = 14;
            this.lblCustoEstimado.Text = "Valor a Gastar Estimado";
            // 
            // txtResultadoValor
            // 
            this.txtResultadoValor.BackColor = System.Drawing.Color.LightGray;
            this.txtResultadoValor.Location = new System.Drawing.Point(400, 217);
            this.txtResultadoValor.Name = "txtResultadoValor";
            this.txtResultadoValor.Size = new System.Drawing.Size(212, 20);
            this.txtResultadoValor.TabIndex = 15;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(372, 258);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 38);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCalcularCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(681, 335);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtResultadoValor);
            this.Controls.Add(this.lblCustoEstimado);
            this.Controls.Add(this.lblCombustivelConsumir);
            this.Controls.Add(this.txtResultadoCombustivel);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.chkIdaVolta);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.txtConsumoMedio);
            this.Controls.Add(this.lblConsumoMedio);
            this.Controls.Add(this.lstTipoCombustível);
            this.Controls.Add(this.lblTipoCombustível);
            this.Controls.Add(this.txtValorCombustivel);
            this.Controls.Add(this.lblValorDoCombustivel);
            this.Controls.Add(this.lblOrientacao);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalcularCombustivel";
            this.Text = "Calcular Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblOrientacao;
        private System.Windows.Forms.Label lblValorDoCombustivel;
        private System.Windows.Forms.TextBox txtValorCombustivel;
        private System.Windows.Forms.Label lblTipoCombustível;
        private System.Windows.Forms.ListBox lstTipoCombustível;
        private System.Windows.Forms.Label lblConsumoMedio;
        private System.Windows.Forms.TextBox txtConsumoMedio;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.CheckBox chkIdaVolta;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultadoCombustivel;
        private System.Windows.Forms.Label lblCombustivelConsumir;
        private System.Windows.Forms.Label lblCustoEstimado;
        private System.Windows.Forms.TextBox txtResultadoValor;
        private System.Windows.Forms.Button btnVoltar;
    }
}