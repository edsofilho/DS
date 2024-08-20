namespace exemplo_crud
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
            this.tex_cpf = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.but_salvar = new System.Windows.Forms.Button();
            this.tex_codigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tex_sobrenome = new System.Windows.Forms.TextBox();
            this.tex_nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_cpf
            // 
            this.tex_cpf.Location = new System.Drawing.Point(105, 67);
            this.tex_cpf.Name = "tex_cpf";
            this.tex_cpf.Size = new System.Drawing.Size(100, 20);
            this.tex_cpf.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.but_salvar);
            this.groupBox1.Controls.Add(this.tex_codigo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tex_sobrenome);
            this.groupBox1.Controls.Add(this.tex_nome);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tex_cpf);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 247);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão colaborador";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = global::exemplo_crud.Properties.Resources.atualizar__1_;
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpar.Location = new System.Drawing.Point(492, 170);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(101, 57);
            this.btn_limpar.TabIndex = 17;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = global::exemplo_crud.Properties.Resources.limpar_limpo__1_;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.Location = new System.Drawing.Point(16, 170);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(90, 55);
            this.btn_alterar.TabIndex = 16;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::exemplo_crud.Properties.Resources.botao_apagar__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(132, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Excluir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Image = global::exemplo_crud.Properties.Resources.documento__1___1_;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultar.Location = new System.Drawing.Point(249, 172);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(113, 55);
            this.btn_consultar.TabIndex = 14;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // but_salvar
            // 
            this.but_salvar.Image = global::exemplo_crud.Properties.Resources.diskette_save_device__1_;
            this.but_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_salvar.Location = new System.Drawing.Point(378, 170);
            this.but_salvar.Name = "but_salvar";
            this.but_salvar.Size = new System.Drawing.Size(93, 59);
            this.but_salvar.TabIndex = 13;
            this.but_salvar.Text = "Salvar";
            this.but_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_salvar.UseVisualStyleBackColor = true;
            this.but_salvar.Click += new System.EventHandler(this.but_salvar_Click);
            // 
            // tex_codigo
            // 
            this.tex_codigo.Location = new System.Drawing.Point(105, 36);
            this.tex_codigo.Name = "tex_codigo";
            this.tex_codigo.ReadOnly = true;
            this.tex_codigo.Size = new System.Drawing.Size(100, 20);
            this.tex_codigo.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Código";
            // 
            // tex_sobrenome
            // 
            this.tex_sobrenome.Location = new System.Drawing.Point(105, 122);
            this.tex_sobrenome.Name = "tex_sobrenome";
            this.tex_sobrenome.Size = new System.Drawing.Size(100, 20);
            this.tex_sobrenome.TabIndex = 10;
            this.tex_sobrenome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tex_nome
            // 
            this.tex_nome.Location = new System.Drawing.Point(105, 93);
            this.tex_nome.Name = "tex_nome";
            this.tex_nome.Size = new System.Drawing.Size(100, 20);
            this.tex_nome.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sobrenome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPF";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(978, 247);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tex_cpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tex_sobrenome;
        private System.Windows.Forms.TextBox tex_nome;
        private System.Windows.Forms.Button but_salvar;
        private System.Windows.Forms.TextBox tex_codigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_alterar;
    }
}

