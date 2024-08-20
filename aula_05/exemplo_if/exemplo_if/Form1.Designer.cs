namespace exemplo_if
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
            this.rdb_manha = new System.Windows.Forms.RadioButton();
            this.rdb_tarde = new System.Windows.Forms.RadioButton();
            this.rdb_noite = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_escolha = new System.Windows.Forms.Button();
            this.rdb_integral = new System.Windows.Forms.RadioButton();
            this.btn_conferir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label_resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_manha
            // 
            this.rdb_manha.AutoSize = true;
            this.rdb_manha.Location = new System.Drawing.Point(27, 19);
            this.rdb_manha.Name = "rdb_manha";
            this.rdb_manha.Size = new System.Drawing.Size(58, 17);
            this.rdb_manha.TabIndex = 0;
            this.rdb_manha.Text = "Manhã";
            this.rdb_manha.UseVisualStyleBackColor = true;
            this.rdb_manha.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_tarde
            // 
            this.rdb_tarde.AutoSize = true;
            this.rdb_tarde.Location = new System.Drawing.Point(27, 42);
            this.rdb_tarde.Name = "rdb_tarde";
            this.rdb_tarde.Size = new System.Drawing.Size(53, 17);
            this.rdb_tarde.TabIndex = 1;
            this.rdb_tarde.Text = "Tarde";
            this.rdb_tarde.UseVisualStyleBackColor = true;
            // 
            // rdb_noite
            // 
            this.rdb_noite.AutoSize = true;
            this.rdb_noite.Location = new System.Drawing.Point(27, 65);
            this.rdb_noite.Name = "rdb_noite";
            this.rdb_noite.Size = new System.Drawing.Size(50, 17);
            this.rdb_noite.TabIndex = 2;
            this.rdb_noite.Text = "Noite";
            this.rdb_noite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_integral);
            this.groupBox1.Controls.Add(this.btn_escolha);
            this.groupBox1.Controls.Add(this.rdb_manha);
            this.groupBox1.Controls.Add(this.rdb_noite);
            this.groupBox1.Controls.Add(this.rdb_tarde);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o periodo";
            // 
            // btn_escolha
            // 
            this.btn_escolha.Location = new System.Drawing.Point(161, 39);
            this.btn_escolha.Name = "btn_escolha";
            this.btn_escolha.Size = new System.Drawing.Size(75, 23);
            this.btn_escolha.TabIndex = 3;
            this.btn_escolha.Text = "Escolher";
            this.btn_escolha.UseVisualStyleBackColor = true;
            this.btn_escolha.Click += new System.EventHandler(this.btn_escolha_Click);
            // 
            // rdb_integral
            // 
            this.rdb_integral.AutoSize = true;
            this.rdb_integral.Location = new System.Drawing.Point(27, 88);
            this.rdb_integral.Name = "rdb_integral";
            this.rdb_integral.Size = new System.Drawing.Size(60, 17);
            this.rdb_integral.TabIndex = 4;
            this.rdb_integral.TabStop = true;
            this.rdb_integral.Text = "Integral";
            this.rdb_integral.UseVisualStyleBackColor = true;
            // 
            // btn_conferir
            // 
            this.btn_conferir.Location = new System.Drawing.Point(39, 212);
            this.btn_conferir.Name = "btn_conferir";
            this.btn_conferir.Size = new System.Drawing.Size(75, 23);
            this.btn_conferir.TabIndex = 4;
            this.btn_conferir.Text = "Conferir";
            this.btn_conferir.UseVisualStyleBackColor = true;
            this.btn_conferir.Click += new System.EventHandler(this.btn_conferir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite um número";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(39, 186);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 6;
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(174, 191);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(35, 13);
            this.label_resultado.TabIndex = 7;
            this.label_resultado.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_conferir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_manha;
        private System.Windows.Forms.RadioButton rdb_tarde;
        private System.Windows.Forms.RadioButton rdb_noite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_escolha;
        private System.Windows.Forms.RadioButton rdb_integral;
        private System.Windows.Forms.Button btn_conferir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label_resultado;
    }
}

