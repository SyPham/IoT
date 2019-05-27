using IoTProject.API.Models;
using IoTProject.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoTProject.API.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateAccount(this Account account, AccountViewModel accountVm)
        {
            account.AccountID = accountVm.AccountID;
            account.CategoryID = accountVm.CategoryID;
            account.Username = accountVm.Username;
            account.Password = accountVm.Password;
            account.Office = accountVm.Office;
        }
    }
}