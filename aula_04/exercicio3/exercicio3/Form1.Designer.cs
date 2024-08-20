namespace exercicio3
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
            this.text_nota1 = new System.Windows.Forms.TextBox();
            this.text_nota3 = new System.Windows.Forms.TextBox();
            this.text_nota2 = new System.Windows.Forms.TextBox();
            this.text_media = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_nota1
            // 
            this.text_nota1.Location = new System.Drawing.Point(12, 51);
            this.text_nota1.Name = "text_nota1";
            this.text_nota1.Size = new System.Drawing.Size(100, 20);
            this.text_nota1.TabIndex = 0;
            this.text_nota1.TextChanged += new System.EventHandler(this.text_nota1_TextChanged);
            // 
            // text_nota3
            // 
            this.text_nota3.Location = new System.Drawing.Point(12, 144);
            this.text_nota3.Name = "text_nota3";
            this.text_nota3.Size = new System.Drawing.Size(100, 20);
            this.text_nota3.TabIndex = 2;
            // 
            // text_nota2
            // 
            this.text_nota2.Location = new System.Drawing.Point(12, 93);
            this.text_nota2.Name = "text_nota2";
            this.text_nota2.Size = new System.Drawing.Size(100, 20);
            this.text_nota2.TabIndex = 3;
            // 
            // text_media
            // 
            this.text_media.Location = new System.Drawing.Point(12, 199);
            this.text_media.Name = "text_media";
            this.text_media.ReadOnly = true;
            this.text_media.Size = new System.Drawing.Size(100, 20);
            this.text_media.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite a primeira nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite a segunda nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite a terceira nota";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Média final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(77, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calcular média final";
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(149, 90);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(123, 23);
            this.button_calcular.TabIndex = 10;
            this.button_calcular.Text = "Calcular média final";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_media);
            this.Controls.Add(this.text_nota2);
            this.Controls.Add(this.text_nota3);
            this.Controls.Add(this.text_nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nota1;
        private System.Windows.Forms.TextBox text_nota3;
        private System.Windows.Forms.TextBox text_nota2;
        private System.Windows.Forms.TextBox text_media;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_calcular;
    }
}

