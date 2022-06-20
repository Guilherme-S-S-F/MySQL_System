using MySQL_System.Entities;
using MySQL_System.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MySQL_System.Model
{
    internal class VendaModel
    {
        VendaDAO dao = new VendaDAO();
        public void InsertData(Vendas dado)
        {
            try
            {
                dao.InsertData(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal object ListData()
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

        internal void EditData(Vendas dado)
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

        internal void DeleteData(Vendas dado)
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

        internal object SearchData(Vendas dado)
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
