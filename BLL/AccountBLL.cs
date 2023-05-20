using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALEntity;

namespace BLL
{
    public class AccountBLL
    {
        AccountDAL accountDAL = new AccountDAL();
        public List<account> getAllAcc()
        {
            return accountDAL.getAllAcc();
        }
        public bool deleteAt(int id)
        {
            return accountDAL.deleteAt(id);
        }
        public bool addAcc_Object(account acc)
        {      
            return accountDAL.addAcc_Object(acc);
        }
        public bool changeAcc_At_Object(int id, account acc)
        {
            return accountDAL.changeAcc_At_Object(id, acc);
        }
        public string user_login(string Username, string pass)
        {
            int kq = accountDAL.user_login(Username, pass);
            if (kq != 0) return accountDAL.check_per(accountDAL.user_login(Username, pass));
            return "Login fail";
        }
    }
}
