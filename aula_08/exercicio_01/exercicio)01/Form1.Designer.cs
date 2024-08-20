namespace exercicio_01
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
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.txt_nota4 = new System.Windows.Forms.TextBox();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular média";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a primeira nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite a segunda nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite a terceira nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digite a quarta nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Média final";
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(35, 58);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 20);
            this.txt_nota1.TabIndex = 6;
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(35, 108);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 20);
            this.txt_nota2.TabIndex = 7;
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(35, 157);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(100, 20);
            this.txt_nota3.TabIndex = 8;
            // 
            // txt_nota4
            // 
            this.txt_nota4.Location = new System.Drawing.Point(35, 196);
            this.txt_nota4.Name = "txt_nota4";
            this.txt_nota4.Size = new System.Drawing.Size(100, 20);
            this.txt_nota4.TabIndex = 9;
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(35, 283);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(100, 20);
            this.txt_media.TabIndex = 10;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(111, 232);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 374);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.txt_nota4);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.TextBox txt_nota4;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Button btn_calcular;
    }
}

