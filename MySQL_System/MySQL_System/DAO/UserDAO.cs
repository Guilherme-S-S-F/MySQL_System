using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySQL_System.DAO
{
    internal class UserDAO
    {
        MySqlCommand sql;
        Connection con = new Connection();
        internal User Login(User dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha", con.con);
                sql.Parameters.AddWithValue("@usuario", dado.Usuario);
                sql.Parameters.AddWithValue("@senha", dado.Senha);

                MySqlDataReader dr;
                dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                    }
                    
                }
                else
                {
                    dado.Usuario = null;
                    dado.Senha = null;
                }
                return dado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
