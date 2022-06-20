using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySQL_System
{
    public class Connection
    {
        string connection = "SERVER=localhost; DATABASE=sistema_clientes; UID=root; PWD=;";
        public MySqlConnection con = null;
                
        public void OpenConnection()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        public void CloseConnection()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
