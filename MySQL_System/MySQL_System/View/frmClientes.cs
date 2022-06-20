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
    public partial class frmClientes : Form
    {
        ClienteModel clienteModel = new ClienteModel();

        public void EnableFields()
        {
            txtb_name.Enabled = true;
            cb_gender.Enabled = true;
            dtp_date.Enabled = true;
        }
        public void DisableFields()
        {
            txtb_name.Enabled = false;
            cb_gender.Enabled = false;
            dtp_date.Enabled = false;
        }
        public void CleanFields()
        {
            txtb_name.Text = "";
            txtb_id.Text = "";
            cb_gender.Text = "";
        }
        public void InsertData(Clientes dado)
        {
            try
            {
                dado.Nome = txtb_name.Text;
                dado.Sexo = cb_gender.Text;
                dado.Nascimento = DateTime.Parse(dtp_date.Text);
                clienteModel.InsertData(dado);
                MessageBox.Show("cliente salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente " + ex.Message);
            }
        }
        public void EditData(Clientes dado)
        {
            try
            {
                dado.Id = int.Parse(txtb_id.Text);
                dado.Nome = txtb_name.Text;
                dado.Sexo = cb_gender.Text;
                dado.Nascimento = DateTime.Parse(dtp_date.Text);
                clienteModel.EditData(dado);
                MessageBox.Show("cliente editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editado o cliente " + ex.Message);
            }
        }
        public void DeleteData(Clientes dado)
        {
            try
            {
                dado.Id = int.Parse(txtb_id.Text);
                
                clienteModel.DeleteData(dado);
                MessageBox.Show("cliente deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o cliente " + ex.Message);
            }
        }
        public void ListData()
        {
            try
            {
                grid_client.DataSource = clienteModel.ListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados: " + ex.Message);
            }
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EnableFields();
            CleanFields();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            InsertData(new Clientes());
            ListData();
            CleanFields();
            DisableFields();
        }

        private void grid_client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_id.Text = grid_client.CurrentRow.Cells[0].Value.ToString();
            txtb_name.Text = grid_client.CurrentRow.Cells[1].Value.ToString();
            cb_gender.Text = grid_client.CurrentRow.Cells[2].Value.ToString();
            dtp_date.Text = grid_client.CurrentRow.Cells[3].Value.ToString();
            EnableFields();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txtb_id.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição.");
                return;
            }
            EditData(new Clientes());
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
            if (MessageBox.Show("Deseja Excluir o Cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            DeleteData(new Clientes());
            ListData();
            CleanFields();
            DisableFields();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchData(new Clientes());

            if (txt_search.Text == "")
            {
                ListData();
                return;
            }
        }
        public void SearchData(Clientes dado)
        {
            try
            {                
                dado.Nome = txt_search.Text;
                grid_client.DataSource = clienteModel.SearchData(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados: " + ex.Message);
            }
        }
                
    }
}
