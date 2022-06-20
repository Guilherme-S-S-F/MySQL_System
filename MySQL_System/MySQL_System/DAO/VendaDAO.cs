using MySql.Data.MySqlClient;
using MySQL_System.Entities;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MySQL_System.DAO
{
    internal class VendaDAO
    {
        MySqlCommand sql;
        Connection con = new Connection();
        public void InsertData(Vendas dado)
        {
            
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO vendas(data, valor, id_cliente) VALUES (@data, @valor, @cliente)", con.con);
                sql.Parameters.AddWithValue("@data", dado.Data);
                sql.Parameters.AddWithValue("@valor", dado.Valor);
                sql.Parameters.AddWithValue("@cliente", dado.Id_cliente);

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        internal void EditData(Vendas dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE vendas SET data = @data, valor = @valor, id_cliente = @id_cliente WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@data", dado.Data);
                sql.Parameters.AddWithValue("@valor", dado.Valor);
                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@id", dado.Id);

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        internal DataTable SearchData(Vendas dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM vendas WHERE id_cliente = @id_cliente", con.con);
                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = sql;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void DeleteData(Vendas dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("DELETE FROM vendas WHERE id = @id", con.con);

                sql.Parameters.AddWithValue("@id", dado.Id);

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        internal DataTable ListData()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM vendas order by id desc", con.con);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = sql;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
