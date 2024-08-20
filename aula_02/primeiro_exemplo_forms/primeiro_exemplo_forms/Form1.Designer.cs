namespace primeiro_exemplo_forms
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
            this.botão = new System.Windows.Forms.Button();
            this.outrobotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botão
            // 
            this.botão.BackColor = System.Drawing.SystemColors.Highlight;
            this.botão.Location = new System.Drawing.Point(32, 96);
            this.botão.Name = "botão";
            this.botão.Size = new System.Drawing.Size(75, 63);
            this.botão.TabIndex = 0;
            this.botão.Text = "Botão";
            this.botão.UseVisualStyleBackColor = false;
            this.botão.Click += new System.EventHandler(this.button1_Click);
            // 
            // outrobotao
            // 
            this.outrobotao.BackColor = System.Drawing.SystemColors.Highlight;
            this.outrobotao.Location = new System.Drawing.Point(172, 96);
            this.outrobotao.Name = "outrobotao";
            this.outrobotao.Size = new System.Drawing.Size(75, 63);
            this.outrobotao.TabIndex = 1;
            this.outrobotao.Text = "Outro botão";
            this.outrobotao.UseVisualStyleBackColor = false;
            this.outrobotao.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(307, 261);
            this.Controls.Add(this.outrobotao);
            this.Controls.Add(this.botão);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botão;
        private System.Windows.Forms.Button outrobotao;
    }
}

