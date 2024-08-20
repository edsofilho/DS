namespace exemplo_encapsulamento
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
            this.btn_Set = new System.Windows.Forms.Button();
            this.btn_Get = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o CPF:";
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(169, 25);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(94, 42);
            this.btn_Set.TabIndex = 6;
            this.btn_Set.Text = "Armazenar em Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(169, 82);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(94, 34);
            this.btn_Get.TabIndex = 7;
            this.btn_Get.Text = "Mostrar em Get";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click_1);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(21, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(21, 96);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mostrar nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mostrar CPF";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(115, 157);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 12;
            this.lb_nome.Text = "Nome";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(115, 185);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(27, 13);
            this.lb_cpf.TabIndex = 13;
            this.lb_cpf.Text = "CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cpf;
    }
}

