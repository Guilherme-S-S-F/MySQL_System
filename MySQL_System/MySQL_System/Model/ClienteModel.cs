using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQL_System.DAO;
using MySQL_System.Entities;

namespace MySQL_System.Model
{
    public class ClienteModel
    {
        ClienteDAO dao = new ClienteDAO();

        public DataTable ListData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListData();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertData(Clientes dado)
        {
            try
            {
                dao.InsertData(dado);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EditData(Clientes dado)
        {
            try
            {
                dao.EditData(dado);
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
                dao.DeleteData(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchData(Clientes dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.SearchData(dado);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
