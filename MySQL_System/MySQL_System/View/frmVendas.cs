using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL_System.Model;
using MySQL_System.Entities;

namespace MySQL_System.View
{
    public partial class frmVendas : Form
    {
        ClienteModel clienteModel = new ClienteModel();
        VendaModel model = new VendaModel();
        public frmVendas()
        {
            InitializeComponent();
        }
        public void EnableFields()
        {
            txtb_valor.Enabled = true;
           cb_cliente.Enabled = true;
            dtp_date.Enabled = true;
        }
        public void DisableFields()
        {
            txtb_valor.Enabled = false;
            cb_cliente.Enabled = false;
            dtp_date.Enabled = false;
        }
        public void CleanFields()
        {
            txtb_valor.Text = "";
            txtb_id.Text = "";           
        }

        public void InsertData(Vendas dado)
        {
            try
            {
                dado.Data = Convert.ToDateTime(dtp_date.Text);
                dado.Id_cliente = Convert.ToInt32(cb_cliente.SelectedValue);
                dado.Valor = Convert.ToDecimal(txtb_valor.Text);
                model.InsertData(dado);
                MessageBox.Show("venda salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente " + ex.Message);
            }
        }
        public void ListData()
        {
            try
            {
                grid_client.DataSource = model.ListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados: " + ex.Message);
            }
        }
        public void EditData(Vendas dado)
        {
            try
            {
                dado.Id = int.Parse(txtb_id.Text);
                dado.Data = DateTime.Parse(dtp_date.Text);
                dado.Id_cliente = Convert.ToInt32(cb_cliente.SelectedValue);
                dado.Valor = Convert.ToDecimal(txtb_valor.Text);
                model.EditData(dado);
                MessageBox.Show("Venda editada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar " + ex.Message);
            }
        }
        public void DeleteData(Vendas dado)
        {
            try
            {
                dado.Id = int.Parse(txtb_id.Text);

                model.DeleteData(dado);
                MessageBox.Show("venda excluida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a venda " + ex.Message);
            }
        }
        private void frmVendas_Load(object sender, EventArgs e)
        {
            ListData();
            cb_cliente.DataSource = clienteModel.ListData();
            cb_cliente.ValueMember = "id";
            cb_cliente.DisplayMember = "nome";

            cb_search.DataSource = clienteModel.ListData();
            cb_search.ValueMember = "id";
            cb_search.DisplayMember = "nome";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EnableFields();
            CleanFields();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            InsertData(new Vendas());
            ListData();
            CleanFields();
            DisableFields();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txtb_id.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição.");
                return;
            }
            EditData(new Vendas());
            ListData();
            CleanFields();
            DisableFields();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txtb_id.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Deseja Excluir a Venda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            DeleteData(new Vendas());
            ListData();
            CleanFields();
            DisableFields();
        }

        private void grid_client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_id.Text = grid_client.CurrentRow.Cells[0].Value.ToString();
            dtp_date.Text = grid_client.CurrentRow.Cells[1].Value.ToString();
            txtb_valor.Text = grid_client.CurrentRow.Cells[2].Value.ToString();
            cb_cliente.SelectedValue = grid_client.CurrentRow.Cells[3].Value.ToString();
            EnableFields();
        }
        public void SearchData(Vendas dado)
        {
            try
            {
                dado.Id_cliente = Convert.ToInt32(cb_search.SelectedValue);
                grid_client.DataSource = model.SearchData(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchData(new Vendas());

            if (cb_search.Text == "")
            {
                ListData();
                return;
            }
        }
    }
}
