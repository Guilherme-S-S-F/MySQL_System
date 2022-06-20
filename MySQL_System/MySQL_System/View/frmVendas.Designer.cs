namespace MySQL_System.View
{
    partial class frmVendas
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.grid_client = new System.Windows.Forms.DataGridView();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txtb_valor = new System.Windows.Forms.TextBox();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.lbl_sellDate = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_sellName = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_client)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(399, 425);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Excluir";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(318, 425);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 26;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(237, 425);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(156, 425);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 24;
            this.btn_new.Text = "Novo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // grid_client
            // 
            this.grid_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_client.Location = new System.Drawing.Point(12, 149);
            this.grid_client.Name = "grid_client";
            this.grid_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_client.Size = new System.Drawing.Size(639, 228);
            this.grid_client.TabIndex = 23;
            this.grid_client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_client_CellClick);
            // 
            // cb_cliente
            // 
            this.cb_cliente.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cb_cliente.Enabled = false;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(127, 121);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(101, 21);
            this.cb_cliente.TabIndex = 22;
            // 
            // dtp_date
            // 
            this.dtp_date.Enabled = false;
            this.dtp_date.Location = new System.Drawing.Point(371, 121);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(225, 20);
            this.dtp_date.TabIndex = 21;
            // 
            // txtb_valor
            // 
            this.txtb_valor.Enabled = false;
            this.txtb_valor.Location = new System.Drawing.Point(371, 78);
            this.txtb_valor.Name = "txtb_valor";
            this.txtb_valor.Size = new System.Drawing.Size(225, 20);
            this.txtb_valor.TabIndex = 20;
            // 
            // txtb_id
            // 
            this.txtb_id.Enabled = false;
            this.txtb_id.Location = new System.Drawing.Point(128, 78);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(51, 20);
            this.txtb_id.TabIndex = 19;
            // 
            // lbl_sellDate
            // 
            this.lbl_sellDate.AutoSize = true;
            this.lbl_sellDate.Location = new System.Drawing.Point(258, 127);
            this.lbl_sellDate.Name = "lbl_sellDate";
            this.lbl_sellDate.Size = new System.Drawing.Size(81, 13);
            this.lbl_sellDate.TabIndex = 18;
            this.lbl_sellDate.Text = "Data da venda:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(87, 127);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(42, 13);
            this.lbl_cliente.TabIndex = 17;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_sellName
            // 
            this.lbl_sellName.AutoSize = true;
            this.lbl_sellName.Location = new System.Drawing.Point(258, 81);
            this.lbl_sellName.Name = "lbl_sellName";
            this.lbl_sellName.Size = new System.Drawing.Size(82, 13);
            this.lbl_sellName.TabIndex = 16;
            this.lbl_sellName.Text = "Valor da venda:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(87, 81);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "id:";
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(156, 19);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(297, 21);
            this.cb_search.TabIndex = 30;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(459, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 31;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grid_client);
            this.Controls.Add(this.cb_cliente);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txtb_valor);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.lbl_sellDate);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_sellName);
            this.Controls.Add(this.lbl_id);
            this.Name = "frmVendas";
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView grid_client;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txtb_valor;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label lbl_sellDate;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_sellName;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Button btn_search;
    }
}