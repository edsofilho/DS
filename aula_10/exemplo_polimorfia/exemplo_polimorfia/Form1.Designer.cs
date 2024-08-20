namespace exemplo_polimorfia
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_vencimento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_btn_assalariado = new System.Windows.Forms.RadioButton();
            this.rad_btn_horista = new System.Windows.Forms.RadioButton();
            this.rad_btn_comissionado = new System.Windows.Forms.RadioButton();
            this.lab_nome = new System.Windows.Forms.Label();
            this.lab_sobrenome = new System.Windows.Forms.Label();
            this.lab_cpf = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(80, 28);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(80, 54);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(100, 20);
            this.txt_sobrenome.TabIndex = 1;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(80, 80);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 2;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(334, 273);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar.TabIndex = 3;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.txt_sobrenome);
            this.groupBox1.Location = new System.Drawing.Point(27, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_vencimento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(273, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vencimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor do vencimento:";
            // 
            // lab_vencimento
            // 
            this.lab_vencimento.AutoSize = true;
            this.lab_vencimento.Location = new System.Drawing.Point(125, 38);
            this.lab_vencimento.Name = "lab_vencimento";
            this.lab_vencimento.Size = new System.Drawing.Size(53, 13);
            this.lab_vencimento.TabIndex = 1;
            this.lab_vencimento.Text = "00/00/00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_btn_comissionado);
            this.groupBox3.Controls.Add(this.rad_btn_horista);
            this.groupBox3.Controls.Add(this.rad_btn_assalariado);
            this.groupBox3.Location = new System.Drawing.Point(27, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 126);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo empregado";
            // 
            // rad_btn_assalariado
            // 
            this.rad_btn_assalariado.AutoSize = true;
            this.rad_btn_assalariado.Location = new System.Drawing.Point(17, 40);
            this.rad_btn_assalariado.Name = "rad_btn_assalariado";
            this.rad_btn_assalariado.Size = new System.Drawing.Size(79, 17);
            this.rad_btn_assalariado.TabIndex = 0;
            this.rad_btn_assalariado.TabStop = true;
            this.rad_btn_assalariado.Text = "Assalariado";
            this.rad_btn_assalariado.UseVisualStyleBackColor = true;
            // 
            // rad_btn_horista
            // 
            this.rad_btn_horista.AutoSize = true;
            this.rad_btn_horista.Location = new System.Drawing.Point(17, 63);
            this.rad_btn_horista.Name = "rad_btn_horista";
            this.rad_btn_horista.Size = new System.Drawing.Size(58, 17);
            this.rad_btn_horista.TabIndex = 1;
            this.rad_btn_horista.TabStop = true;
            this.rad_btn_horista.Text = "Horista";
            this.rad_btn_horista.UseVisualStyleBackColor = true;
            // 
            // rad_btn_comissionado
            // 
            this.rad_btn_comissionado.AutoSize = true;
            this.rad_btn_comissionado.Location = new System.Drawing.Point(17, 86);
            this.rad_btn_comissionado.Name = "rad_btn_comissionado";
            this.rad_btn_comissionado.Size = new System.Drawing.Size(90, 17);
            this.rad_btn_comissionado.TabIndex = 2;
            this.rad_btn_comissionado.TabStop = true;
            this.rad_btn_comissionado.Text = "Comissionado";
            this.rad_btn_comissionado.UseVisualStyleBackColor = true;
            // 
            // lab_nome
            // 
            this.lab_nome.AutoSize = true;
            this.lab_nome.Location = new System.Drawing.Point(18, 33);
            this.lab_nome.Name = "lab_nome";
            this.lab_nome.Size = new System.Drawing.Size(35, 13);
            this.lab_nome.TabIndex = 7;
            this.lab_nome.Text = "Nome";
            this.lab_nome.Click += new System.EventHandler(this.label5_Click);
            // 
            // lab_sobrenome
            // 
            this.lab_sobrenome.AutoSize = true;
            this.lab_sobrenome.Location = new System.Drawing.Point(18, 57);
            this.lab_sobrenome.Name = "lab_sobrenome";
            this.lab_sobrenome.Size = new System.Drawing.Size(61, 13);
            this.lab_sobrenome.TabIndex = 8;
            this.lab_sobrenome.Text = "Sobrenome";
            // 
            // lab_cpf
            // 
            this.lab_cpf.AutoSize = true;
            this.lab_cpf.Location = new System.Drawing.Point(18, 86);
            this.lab_cpf.Name = "lab_cpf";
            this.lab_cpf.Size = new System.Drawing.Size(27, 13);
            this.lab_cpf.TabIndex = 9;
            this.lab_cpf.Text = "CPF";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lab_nome);
            this.groupBox4.Controls.Add(this.lab_cpf);
            this.groupBox4.Controls.Add(this.lab_sobrenome);
            this.groupBox4.Location = new System.Drawing.Point(532, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 119);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 418);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_verificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_vencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_btn_comissionado;
        private System.Windows.Forms.RadioButton rad_btn_horista;
        private System.Windows.Forms.RadioButton rad_btn_assalariado;
        private System.Windows.Forms.Label lab_nome;
        private System.Windows.Forms.Label lab_sobrenome;
        private System.Windows.Forms.Label lab_cpf;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

