using IoTProject.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Model.dao
{
    public class AccountDao
    {
        WebApiDbContext db = null;
        public AccountDao()
        {
            db = new WebApiDbContext();
        }

        public bool Add(Account account)
        {
            Account item = new Account();
            item.AccountID = account.AccountID;
            item.Username = account.Username;
            item.Password = account.Password;
            item.Office = account.Office;
            item.CategoryID = account.CategoryID;
            
            try
            {
                db.Accounts.Add(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var item = db.Accounts.FirstOrDefault(x => x.AccountID == id);
            if (item == null)
                return false;
            try
            {
                db.Accounts.Remove(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            


        }

        public List<Account> GetAll()
        {
            return db.Accounts.ToList();
        }
    }
}
