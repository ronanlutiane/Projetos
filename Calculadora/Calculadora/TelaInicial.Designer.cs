﻿namespace Calculadora
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculadoraPadrao = new System.Windows.Forms.Button();
            this.btnCombustivel = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnJur_Comp = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a  calculadora que deseja abrir:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnCalculadoraPadrao
            // 
            this.btnCalculadoraPadrao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalculadoraPadrao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculadoraPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadoraPadrao.Location = new System.Drawing.Point(57, 113);
            this.btnCalculadoraPadrao.Name = "btnCalculadoraPadrao";
            this.btnCalculadoraPadrao.Size = new System.Drawing.Size(115, 56);
            this.btnCalculadoraPadrao.TabIndex = 1;
            this.btnCalculadoraPadrao.Text = "Padrão";
            this.btnCalculadoraPadrao.UseVisualStyleBackColor = true;
            this.btnCalculadoraPadrao.Click += new System.EventHandler(this.btnCalculadoraPadrao_Click);
            // 
            // btnCombustivel
            // 
            this.btnCombustivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombustivel.Location = new System.Drawing.Point(322, 113);
            this.btnCombustivel.Name = "btnCombustivel";
            this.btnCombustivel.Size = new System.Drawing.Size(115, 56);
            this.btnCombustivel.TabIndex = 2;
            this.btnCombustivel.Text = "Combustível";
            this.btnCombustivel.UseVisualStyleBackColor = true;
            this.btnCombustivel.Click += new System.EventHandler(this.btnCombustivel_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTemp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.Location = new System.Drawing.Point(57, 206);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(115, 56);
            this.btnTemp.TabIndex = 3;
            this.btnTemp.Text = "Temperatura";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.BtnTemp_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(322, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 56);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnJur_Comp
            // 
            this.btnJur_Comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJur_Comp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJur_Comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJur_Comp.Location = new System.Drawing.Point(192, 113);
            this.btnJur_Comp.Name = "btnJur_Comp";
            this.btnJur_Comp.Size = new System.Drawing.Size(115, 56);
            this.btnJur_Comp.TabIndex = 5;
            this.btnJur_Comp.Text = "Juros Compostos";
            this.btnJur_Comp.UseVisualStyleBackColor = true;
            this.btnJur_Comp.Click += new System.EventHandler(this.BtnJur_Comp_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(192, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 367);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnJur_Comp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnCombustivel);
            this.Controls.Add(this.btnCalculadoraPadrao);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculadoraPadrao;
        private System.Windows.Forms.Button btnCombustivel;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnJur_Comp;
        private System.Windows.Forms.Button button6;
    }
}

