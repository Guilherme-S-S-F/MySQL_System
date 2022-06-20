using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQL_System.DAO;

namespace MySQL_System.Model
{
    public class UserModel
    {
        UserDAO dao = new UserDAO();
        public User Login(User dado)
        {
            try
            {
                return dao.Login(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
