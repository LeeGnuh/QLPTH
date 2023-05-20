using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity
{
    public class AccountDAL
    {
        QLPTHEntities db = new QLPTHEntities();
        List<account> ListAcc = new List<account>();
        public List<account> getAllAcc()
        {
            var result = from a in db.accounts select a;
            ListAcc = result.ToList();
            return ListAcc;
        }
        public List<account> select_id(int id)
        {
            var result = from a in db.accounts where a.id_acc == id select a;
            ListAcc = result.ToList();
            return (ListAcc.Count > 0) ? ListAcc : null;
        }
        public bool deleteAt(int id)
        {
            account a = db.accounts.Find(id);
            if (a != null) { db.accounts.Remove(a); db.SaveChanges(); }
            return a != null;
        }
        public bool addAcc_Object(account acc)
        {
            db.accounts.Add(acc);
            db.SaveChanges();
            return acc != null;
        }
        public bool changeAcc_At_Object(int id, account acc)
        {
            account a = db.accounts.Find(id);
            if (a != null)
            {
                a.id_acc = acc.id_acc;
                a.username = acc.username;
                a.password = acc.password;
                a.id_per = acc.id_per;
                a.full_name = acc.full_name;
                a.acc_ban = acc.acc_ban;
                db.SaveChanges();
            }
            return a != null;
        }
        public int user_login(string username, string pass)
        {
            var result = from a in db.accounts where a.username == username && a.password == pass select a;
            return result.Count() > 0 ? (int)result.First().id_per : 0;
        }
        public string check_per(int id)
        {
            var result = from p in db.permisions where p.id_per == id select p;
            return result.First().name_per.ToString();
        }
    }
}
