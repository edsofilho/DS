﻿namespace Exemplo_herança
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_cartao = new System.Windows.Forms.Label();
            this.lb_rg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite seu cartão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite seu RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cartão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "RG:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(101, 22);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(101, 46);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(100, 20);
            this.txt_cartao.TabIndex = 7;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(101, 74);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(100, 20);
            this.txt_rg.TabIndex = 8;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(216, 35);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(91, 41);
            this.btn.TabIndex = 9;
            this.btn.Text = "Armazenar e demonstar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(79, 130);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 10;
            this.lb_nome.Text = "Nome";
            // 
            // lb_cartao
            // 
            this.lb_cartao.AutoSize = true;
            this.lb_cartao.Location = new System.Drawing.Point(79, 158);
            this.lb_cartao.Name = "lb_cartao";
            this.lb_cartao.Size = new System.Drawing.Size(38, 13);
            this.lb_cartao.TabIndex = 11;
            this.lb_cartao.Text = "Cartão";
            // 
            // lb_rg
            // 
            this.lb_rg.AutoSize = true;
            this.lb_rg.Location = new System.Drawing.Point(79, 185);
            this.lb_rg.Name = "lb_rg";
            this.lb_rg.Size = new System.Drawing.Size(23, 13);
            this.lb_rg.TabIndex = 12;
            this.lb_rg.Text = "RG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.lb_rg);
            this.Controls.Add(this.lb_cartao);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.txt_cartao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cartao;
        private System.Windows.Forms.Label lb_rg;
    }
}

