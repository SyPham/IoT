using IoTProject.API.Infrastructure.Core;
using IoTProject.API.Infrastructure.Extensions;
using IoTProject.API.Models;
using IoTProject.Model;
using IoTProject.Model.dao;
using IoTProject.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoTProject.API.Controllers
{
    public class AccountController : ApiControllerBase
    {
        public AccountController()
        {
        }

        [Route("api/accounts")]
        public IEnumerable<Account> GetAccounts()
        {
            return new AccountDao().GetAll();
        }
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, AccountViewModel accountVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    Account newAccount = new Account();
                    newAccount.UpdateAccount(accountVm);

                    var acc = new AccountDao().Add(newAccount);

                    response = request.CreateResponse(HttpStatusCode.Created, acc);
                }
                return response;
            });
        }

    }
}
