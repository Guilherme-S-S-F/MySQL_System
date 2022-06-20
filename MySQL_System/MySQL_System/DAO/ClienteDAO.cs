using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySQL_System.Entities;

namespace MySQL_System.DAO
{
    public class ClienteDAO
    {
        //string connection = "SERVER=localhost; DATABASE=sistema_clientes; UID=root; PWD=;";
        //MySqlConnection con = null;
        MySqlCommand sql;
        Connection con = new Connection();

        public DataTable ListData()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM clientes", con.con);
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

        public void EditData(Clientes dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE clientes SET nome = @nome, sexo = @sexo, nascimento = @nascimento WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@sexo", dado.Sexo);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);
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

        public DataTable SearchData(Clientes dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM clientes WHERE nome LIKE @nome", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome + "%");
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

        public void DeleteData(Clientes dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("DELETE FROM clientes WHERE id = @id", con.con);
                
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

        public void InsertData(Clientes dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO clientes(nome, sexo, nascimento) VALUES (@nome, @sexo, @nascimento)", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@sexo", dado.Sexo);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);

                sql.ExecuteNonQuery();                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }
    }
}
