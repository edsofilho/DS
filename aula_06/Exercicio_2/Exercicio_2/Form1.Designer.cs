namespace Exercicio_2
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite sua altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite seu peso";
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(169, 88);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(51, 13);
            this.label_resultado.TabIndex = 3;
            this.label_resultado.Text = "Seu IMC:";
            this.label_resultado.Click += new System.EventHandler(this.label_resultado_Click);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(32, 65);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 4;
            this.txt_altura.TextChanged += new System.EventHandler(this.txt_altura_TextChanged);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(32, 117);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 5;
            this.txt_peso.TextChanged += new System.EventHandler(this.txt_peso_TextChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(32, 152);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Button btn_calcular;
    }
}

