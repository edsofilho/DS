namespace exercicio_2
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
            this.txt_brancos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nulos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_validos = new System.Windows.Forms.TextBox();
            this.calcular_button = new System.Windows.Forms.Button();
            this.brancos_resultado = new System.Windows.Forms.TextBox();
            this.nulos_resultado = new System.Windows.Forms.TextBox();
            this.validos_resultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELEITORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o total de votos brancos";
            // 
            // txt_brancos
            // 
            this.txt_brancos.Location = new System.Drawing.Point(15, 57);
            this.txt_brancos.Name = "txt_brancos";
            this.txt_brancos.Size = new System.Drawing.Size(100, 20);
            this.txt_brancos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o total de votos nulos";
            // 
            // txt_nulos
            // 
            this.txt_nulos.Location = new System.Drawing.Point(15, 96);
            this.txt_nulos.Name = "txt_nulos";
            this.txt_nulos.Size = new System.Drawing.Size(100, 20);
            this.txt_nulos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Digite o total de votos válidos";
            // 
            // txt_validos
            // 
            this.txt_validos.Location = new System.Drawing.Point(15, 135);
            this.txt_validos.Name = "txt_validos";
            this.txt_validos.Size = new System.Drawing.Size(100, 20);
            this.txt_validos.TabIndex = 6;
            // 
            // calcular_button
            // 
            this.calcular_button.Location = new System.Drawing.Point(100, 173);
            this.calcular_button.Name = "calcular_button";
            this.calcular_button.Size = new System.Drawing.Size(75, 23);
            this.calcular_button.TabIndex = 7;
            this.calcular_button.Text = "Calcular";
            this.calcular_button.UseVisualStyleBackColor = true;
            this.calcular_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // brancos_resultado
            // 
            this.brancos_resultado.Location = new System.Drawing.Point(15, 212);
            this.brancos_resultado.Name = "brancos_resultado";
            this.brancos_resultado.ReadOnly = true;
            this.brancos_resultado.Size = new System.Drawing.Size(78, 20);
            this.brancos_resultado.TabIndex = 8;
            // 
            // nulos_resultado
            // 
            this.nulos_resultado.Location = new System.Drawing.Point(15, 238);
            this.nulos_resultado.Name = "nulos_resultado";
            this.nulos_resultado.ReadOnly = true;
            this.nulos_resultado.Size = new System.Drawing.Size(79, 20);
            this.nulos_resultado.TabIndex = 9;
            // 
            // validos_resultado
            // 
            this.validos_resultado.Location = new System.Drawing.Point(16, 264);
            this.validos_resultado.Name = "validos_resultado";
            this.validos_resultado.ReadOnly = true;
            this.validos_resultado.Size = new System.Drawing.Size(78, 20);
            this.validos_resultado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "dos votos foram brancos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "dos votos foram nulos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "dos votos foram validos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.validos_resultado);
            this.Controls.Add(this.nulos_resultado);
            this.Controls.Add(this.brancos_resultado);
            this.Controls.Add(this.calcular_button);
            this.Controls.Add(this.txt_validos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_brancos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_brancos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nulos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_validos;
        private System.Windows.Forms.Button calcular_button;
        private System.Windows.Forms.TextBox brancos_resultado;
        private System.Windows.Forms.TextBox nulos_resultado;
        private System.Windows.Forms.TextBox validos_resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

