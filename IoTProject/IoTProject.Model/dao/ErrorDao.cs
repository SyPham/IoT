using IoTProject.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Model.dao
{
  public  class ErrorDao
    {
        WebApiDbContext db = null;

        public ErrorDao()
        {
            this.db =new WebApiDbContext();
        }
        public bool Create(Error error)
        {
            Error item = new Error();
            item.ID = error.ID;
            item.Message = error.Message;
            item.StackTrace = error.StackTrace;
            item.CreatedDate = error.CreatedDate;

            try
            {
                db.Errors.Add(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
