namespace exercicio_02
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_est = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.txt_resul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repositar estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade maxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade em estoque";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(30, 70);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(30, 115);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(100, 20);
            this.txt_max.TabIndex = 5;
            // 
            // txt_est
            // 
            this.txt_est.Location = new System.Drawing.Point(30, 154);
            this.txt_est.Name = "txt_est";
            this.txt_est.Size = new System.Drawing.Size(100, 20);
            this.txt_est.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(171, 112);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_resul
            // 
            this.txt_resul.Location = new System.Drawing.Point(283, 116);
            this.txt_resul.Name = "txt_resul";
            this.txt_resul.Size = new System.Drawing.Size(100, 20);
            this.txt_resul.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Compre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_resul);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt_est);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.TextBox txt_est;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt_resul;
        private System.Windows.Forms.Label label5;
    }
}

