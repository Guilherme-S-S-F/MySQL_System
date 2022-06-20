namespace MySQL_System
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_clienteForm = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clienteForm
            // 
            this.btn_clienteForm.Location = new System.Drawing.Point(12, 12);
            this.btn_clienteForm.Name = "btn_clienteForm";
            this.btn_clienteForm.Size = new System.Drawing.Size(75, 23);
            this.btn_clienteForm.TabIndex = 0;
            this.btn_clienteForm.Text = "Clientes";
            this.btn_clienteForm.UseVisualStyleBackColor = true;
            this.btn_clienteForm.Click += new System.EventHandler(this.btn_clienteForm_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.Location = new System.Drawing.Point(119, 12);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(75, 23);
            this.btn_vendas.TabIndex = 1;
            this.btn_vendas.Text = "Vendas";
            this.btn_vendas.UseVisualStyleBackColor = true;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 98);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_clienteForm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clienteForm;
        private System.Windows.Forms.Button btn_vendas;
    }
}

