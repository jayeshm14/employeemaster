using EmployeeManager.BAL;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagerService.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage UserRegistration([FromBody] RegistrationModel UserProfile)
        {
            HttpResponseMessage response = null;
            CommonResponseModel commonReponse = new CommonResponseModel();

            try
            {
                AccountBL account = new AccountBL();
                commonReponse = account.UserRegistration(UserProfile);
                response = this.Request.CreateResponse(HttpStatusCode.OK, commonReponse);
            }
            catch(Exception ex)
            {
                commonReponse.Status = 0;
                commonReponse.Message = "Internal Server Error";
                response = this.Request.CreateResponse(HttpStatusCode.OK, commonReponse);
            }

            return response;
        }
    }
}
