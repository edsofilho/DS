namespace estrutura_projeto
{
    partial class frm_login
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(91, 41);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(91, 83);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // btn_sair
            // 
            this.btn_sair.Image = global::estrutura_projeto.Properties.Resources.sair__1_;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(259, 84);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(129, 55);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_acessar
            // 
            this.btn_acessar.Image = global::estrutura_projeto.Properties.Resources.conecte_se__1_;
            this.btn_acessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acessar.Location = new System.Drawing.Point(259, 22);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(129, 56);
            this.btn_acessar.TabIndex = 4;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_acessar.UseVisualStyleBackColor = true;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.Button btn_sair;
    }
}