namespace Atividade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tex_modelo = new System.Windows.Forms.TextBox();
            this.tex_cor = new System.Windows.Forms.TextBox();
            this.tex_ano = new System.Windows.Forms.TextBox();
            this.tex_portas = new System.Windows.Forms.TextBox();
            this.tex_marca = new System.Windows.Forms.TextBox();
            this.tex_combustivel = new System.Windows.Forms.TextBox();
            this.but_armazenar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_modelo = new System.Windows.Forms.Label();
            this.lab_cor = new System.Windows.Forms.Label();
            this.lab_ano = new System.Windows.Forms.Label();
            this.lab_portas = new System.Windows.Forms.Label();
            this.lab_marca = new System.Windows.Forms.Label();
            this.lab_combustivel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tex_combustivel);
            this.groupBox1.Controls.Add(this.tex_marca);
            this.groupBox1.Controls.Add(this.tex_portas);
            this.groupBox1.Controls.Add(this.tex_ano);
            this.groupBox1.Controls.Add(this.tex_cor);
            this.groupBox1.Controls.Add(this.tex_modelo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite os dados do carro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Portas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Combustivel";
            // 
            // tex_modelo
            // 
            this.tex_modelo.Location = new System.Drawing.Point(88, 28);
            this.tex_modelo.Name = "tex_modelo";
            this.tex_modelo.Size = new System.Drawing.Size(100, 20);
            this.tex_modelo.TabIndex = 6;
            // 
            // tex_cor
            // 
            this.tex_cor.Location = new System.Drawing.Point(88, 57);
            this.tex_cor.Name = "tex_cor";
            this.tex_cor.Size = new System.Drawing.Size(100, 20);
            this.tex_cor.TabIndex = 7;
            // 
            // tex_ano
            // 
            this.tex_ano.Location = new System.Drawing.Point(88, 88);
            this.tex_ano.Name = "tex_ano";
            this.tex_ano.Size = new System.Drawing.Size(100, 20);
            this.tex_ano.TabIndex = 8;
            // 
            // tex_portas
            // 
            this.tex_portas.Location = new System.Drawing.Point(88, 124);
            this.tex_portas.Name = "tex_portas";
            this.tex_portas.Size = new System.Drawing.Size(100, 20);
            this.tex_portas.TabIndex = 9;
            // 
            // tex_marca
            // 
            this.tex_marca.Location = new System.Drawing.Point(88, 157);
            this.tex_marca.Name = "tex_marca";
            this.tex_marca.Size = new System.Drawing.Size(100, 20);
            this.tex_marca.TabIndex = 10;
            // 
            // tex_combustivel
            // 
            this.tex_combustivel.Location = new System.Drawing.Point(88, 192);
            this.tex_combustivel.Name = "tex_combustivel";
            this.tex_combustivel.Size = new System.Drawing.Size(100, 20);
            this.tex_combustivel.TabIndex = 11;
            // 
            // but_armazenar
            // 
            this.but_armazenar.Location = new System.Drawing.Point(355, 107);
            this.but_armazenar.Name = "but_armazenar";
            this.but_armazenar.Size = new System.Drawing.Size(75, 23);
            this.but_armazenar.TabIndex = 1;
            this.but_armazenar.Text = "Armazenar";
            this.but_armazenar.UseVisualStyleBackColor = true;
            this.but_armazenar.Click += new System.EventHandler(this.but_armazenar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lab_combustivel);
            this.groupBox2.Controls.Add(this.lab_marca);
            this.groupBox2.Controls.Add(this.lab_portas);
            this.groupBox2.Controls.Add(this.lab_ano);
            this.groupBox2.Controls.Add(this.lab_cor);
            this.groupBox2.Controls.Add(this.lab_modelo);
            this.groupBox2.Location = new System.Drawing.Point(504, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do carro";
            // 
            // lab_modelo
            // 
            this.lab_modelo.AutoSize = true;
            this.lab_modelo.Location = new System.Drawing.Point(105, 31);
            this.lab_modelo.Name = "lab_modelo";
            this.lab_modelo.Size = new System.Drawing.Size(41, 13);
            this.lab_modelo.TabIndex = 6;
            this.lab_modelo.Text = "modelo";
            // 
            // lab_cor
            // 
            this.lab_cor.AutoSize = true;
            this.lab_cor.Location = new System.Drawing.Point(105, 64);
            this.lab_cor.Name = "lab_cor";
            this.lab_cor.Size = new System.Drawing.Size(22, 13);
            this.lab_cor.TabIndex = 7;
            this.lab_cor.Text = "cor";
            // 
            // lab_ano
            // 
            this.lab_ano.AutoSize = true;
            this.lab_ano.Location = new System.Drawing.Point(105, 95);
            this.lab_ano.Name = "lab_ano";
            this.lab_ano.Size = new System.Drawing.Size(25, 13);
            this.lab_ano.TabIndex = 8;
            this.lab_ano.Text = "ano";
            // 
            // lab_portas
            // 
            this.lab_portas.AutoSize = true;
            this.lab_portas.Location = new System.Drawing.Point(105, 127);
            this.lab_portas.Name = "lab_portas";
            this.lab_portas.Size = new System.Drawing.Size(36, 13);
            this.lab_portas.TabIndex = 9;
            this.lab_portas.Text = "portas";
            // 
            // lab_marca
            // 
            this.lab_marca.AutoSize = true;
            this.lab_marca.Location = new System.Drawing.Point(105, 160);
            this.lab_marca.Name = "lab_marca";
            this.lab_marca.Size = new System.Drawing.Size(36, 13);
            this.lab_marca.TabIndex = 10;
            this.lab_marca.Text = "marca";
            // 
            // lab_combustivel
            // 
            this.lab_combustivel.AutoSize = true;
            this.lab_combustivel.Location = new System.Drawing.Point(105, 195);
            this.lab_combustivel.Name = "lab_combustivel";
            this.lab_combustivel.Size = new System.Drawing.Size(63, 13);
            this.lab_combustivel.TabIndex = 11;
            this.lab_combustivel.Text = "combustivel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Combustivel:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Marca:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Portas:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ano:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cor:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Modelo:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.but_armazenar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_combustivel;
        private System.Windows.Forms.TextBox tex_marca;
        private System.Windows.Forms.TextBox tex_portas;
        private System.Windows.Forms.TextBox tex_ano;
        private System.Windows.Forms.TextBox tex_cor;
        private System.Windows.Forms.TextBox tex_modelo;
        private System.Windows.Forms.Button but_armazenar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lab_combustivel;
        private System.Windows.Forms.Label lab_marca;
        private System.Windows.Forms.Label lab_portas;
        private System.Windows.Forms.Label lab_ano;
        private System.Windows.Forms.Label lab_cor;
        private System.Windows.Forms.Label lab_modelo;
    }
}

