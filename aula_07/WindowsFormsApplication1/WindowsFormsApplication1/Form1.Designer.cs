namespace WindowsFormsApplication1
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
            this.btn_sub = new System.Windows.Forms.Button();
            this.text_numero1 = new System.Windows.Forms.TextBox();
            this.text_numero2 = new System.Windows.Forms.TextBox();
            this.text_resultado = new System.Windows.Forms.TextBox();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_som = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o segundo número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(178, 39);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 3;
            this.btn_sub.Text = "Somar";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.button_somar_Click);
            // 
            // text_numero1
            // 
            this.text_numero1.Location = new System.Drawing.Point(35, 42);
            this.text_numero1.Name = "text_numero1";
            this.text_numero1.Size = new System.Drawing.Size(100, 20);
            this.text_numero1.TabIndex = 4;
            this.text_numero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_numero2
            // 
            this.text_numero2.Location = new System.Drawing.Point(35, 90);
            this.text_numero2.Name = "text_numero2";
            this.text_numero2.Size = new System.Drawing.Size(100, 20);
            this.text_numero2.TabIndex = 5;
            // 
            // text_resultado
            // 
            this.text_resultado.Location = new System.Drawing.Point(35, 153);
            this.text_resultado.Name = "text_resultado";
            this.text_resultado.ReadOnly = true;
            this.text_resultado.Size = new System.Drawing.Size(100, 20);
            this.text_resultado.TabIndex = 6;
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(178, 87);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 7;
            this.btn_div.Text = "Dividir";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(281, 90);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(75, 23);
            this.btn_mul.TabIndex = 8;
            this.btn_mul.Text = "Multiplicar";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_som
            // 
            this.btn_som.Location = new System.Drawing.Point(281, 40);
            this.btn_som.Name = "btn_som";
            this.btn_som.Size = new System.Drawing.Size(75, 23);
            this.btn_som.TabIndex = 9;
            this.btn_som.Text = "Subtrair";
            this.btn_som.UseVisualStyleBackColor = true;
            this.btn_som.Click += new System.EventHandler(this.btn_som_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.btn_som);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.text_resultado);
            this.Controls.Add(this.text_numero2);
            this.Controls.Add(this.text_numero1);
            this.Controls.Add(this.btn_sub);
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
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.TextBox text_numero1;
        private System.Windows.Forms.TextBox text_numero2;
        private System.Windows.Forms.TextBox text_resultado;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_som;
    }
}

