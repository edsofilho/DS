namespace exercicio_03
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
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_val = new System.Windows.Forms.TextBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(15, 101);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(100, 20);
            this.txt_tax.TabIndex = 1;
            // 
            // txt_val
            // 
            this.txt_val.Location = new System.Drawing.Point(15, 42);
            this.txt_val.Name = "txt_val";
            this.txt_val.Size = new System.Drawing.Size(100, 20);
            this.txt_val.TabIndex = 2;
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(15, 157);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(100, 20);
            this.txt_dia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o valor da pretação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite a taxa de juros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dias em atraso";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(168, 98);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 7;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(289, 101);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(100, 20);
            this.txt_res.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.txt_val);
            this.Controls.Add(this.txt_tax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_val;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Label label4;
    }
}

