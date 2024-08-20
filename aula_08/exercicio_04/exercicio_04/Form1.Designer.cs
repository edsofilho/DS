namespace exercicio_04
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
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_pagas = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pago = new System.Windows.Forms.TextBox();
            this.txt_restante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o total de prestações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prestações pagas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de cada prestação";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(15, 53);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 4;
            // 
            // txt_pagas
            // 
            this.txt_pagas.Location = new System.Drawing.Point(15, 111);
            this.txt_pagas.Name = "txt_pagas";
            this.txt_pagas.Size = new System.Drawing.Size(100, 20);
            this.txt_pagas.TabIndex = 5;
            this.txt_pagas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(18, 159);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 6;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(172, 95);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 7;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Restante";
            // 
            // txt_pago
            // 
            this.txt_pago.Location = new System.Drawing.Point(290, 72);
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.ReadOnly = true;
            this.txt_pago.Size = new System.Drawing.Size(100, 20);
            this.txt_pago.TabIndex = 10;
            // 
            // txt_restante
            // 
            this.txt_restante.Location = new System.Drawing.Point(290, 130);
            this.txt_restante.Name = "txt_restante";
            this.txt_restante.ReadOnly = true;
            this.txt_restante.Size = new System.Drawing.Size(100, 20);
            this.txt_restante.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 261);
            this.Controls.Add(this.txt_restante);
            this.Controls.Add(this.txt_pago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_pagas);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_pagas;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pago;
        private System.Windows.Forms.TextBox txt_restante;
    }
}

