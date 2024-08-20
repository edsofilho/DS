namespace exemplo_operacao_forms
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
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.txt_numero3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o segundo número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(15, 25);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_numero1.TabIndex = 3;
            this.txt_numero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(15, 68);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_numero2.TabIndex = 4;
            this.txt_numero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_resultado.Location = new System.Drawing.Point(12, 203);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(125, 23);
            this.txt_resultado.TabIndex = 5;
            this.txt_resultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_numero3
            // 
            this.txt_numero3.Location = new System.Drawing.Point(15, 114);
            this.txt_numero3.Name = "txt_numero3";
            this.txt_numero3.Size = new System.Drawing.Size(100, 20);
            this.txt_numero3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite o terceiro número";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Image = global::exemplo_operacao_forms.Properties.Resources.less_3158;
            this.button4.Location = new System.Drawing.Point(259, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 76);
            this.button4.TabIndex = 11;
            this.button4.Text = "Subtrair";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Image = global::exemplo_operacao_forms.Properties.Resources.multiplicationsign_80855;
            this.button3.Location = new System.Drawing.Point(259, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 76);
            this.button3.TabIndex = 10;
            this.button3.Text = "Multiplicar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Image = global::exemplo_operacao_forms.Properties.Resources.divisionsign_81003;
            this.button2.Location = new System.Drawing.Point(169, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 76);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dividir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Image = global::exemplo_operacao_forms.Properties.Resources.Plus_icon_icons_com_71848__1_;
            this.button1.Location = new System.Drawing.Point(170, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = "Somar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(538, 433);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_numero3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
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
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_numero3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

