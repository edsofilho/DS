namespace atividade_pet
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tex_codigo = new System.Windows.Forms.TextBox();
            this.text_idade = new System.Windows.Forms.TextBox();
            this.text_cor = new System.Windows.Forms.TextBox();
            this.text_sexo = new System.Windows.Forms.TextBox();
            this.text_especie = new System.Windows.Forms.TextBox();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tex_codigo);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.text_idade);
            this.groupBox1.Controls.Add(this.text_cor);
            this.groupBox1.Controls.Add(this.text_sexo);
            this.groupBox1.Controls.Add(this.text_especie);
            this.groupBox1.Controls.Add(this.text_nome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do pet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Código";
            // 
            // tex_codigo
            // 
            this.tex_codigo.Location = new System.Drawing.Point(92, 29);
            this.tex_codigo.Name = "tex_codigo";
            this.tex_codigo.ReadOnly = true;
            this.tex_codigo.Size = new System.Drawing.Size(100, 20);
            this.tex_codigo.TabIndex = 13;
            // 
            // text_idade
            // 
            this.text_idade.Location = new System.Drawing.Point(92, 100);
            this.text_idade.Name = "text_idade";
            this.text_idade.Size = new System.Drawing.Size(100, 20);
            this.text_idade.TabIndex = 9;
            // 
            // text_cor
            // 
            this.text_cor.Location = new System.Drawing.Point(293, 36);
            this.text_cor.Name = "text_cor";
            this.text_cor.Size = new System.Drawing.Size(100, 20);
            this.text_cor.TabIndex = 8;
            // 
            // text_sexo
            // 
            this.text_sexo.Location = new System.Drawing.Point(293, 100);
            this.text_sexo.Name = "text_sexo";
            this.text_sexo.Size = new System.Drawing.Size(100, 20);
            this.text_sexo.TabIndex = 7;
            // 
            // text_especie
            // 
            this.text_especie.Location = new System.Drawing.Point(293, 71);
            this.text_especie.Name = "text_especie";
            this.text_especie.Size = new System.Drawing.Size(100, 20);
            this.text_especie.TabIndex = 6;
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(92, 65);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(100, 20);
            this.text_nome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espécie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(841, 246);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Image = global::atividade_pet.Properties.Resources.limpar_limpo__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(558, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = global::atividade_pet.Properties.Resources.atualizar__1_;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.Location = new System.Drawing.Point(415, 144);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(96, 62);
            this.btn_alterar.TabIndex = 15;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Image = global::atividade_pet.Properties.Resources.documento__1___1_;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.Location = new System.Drawing.Point(156, 147);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(102, 61);
            this.btn_consultar.TabIndex = 12;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = global::atividade_pet.Properties.Resources.botao_apagar__1_;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(293, 147);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(91, 56);
            this.btn_excluir.TabIndex = 11;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = global::atividade_pet.Properties.Resources.diskette_save_device__1_;
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.Location = new System.Drawing.Point(26, 147);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(92, 56);
            this.btn_salvar.TabIndex = 10;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 535);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox text_idade;
        private System.Windows.Forms.TextBox text_cor;
        private System.Windows.Forms.TextBox text_sexo;
        private System.Windows.Forms.TextBox text_especie;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tex_codigo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button button1;
    }
}

