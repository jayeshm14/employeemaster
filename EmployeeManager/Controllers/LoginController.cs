using EmployeeManager.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace EmployeeManager.Controllers
{
    public class LoginController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(RegistrationModel ObjRegistrationModel)
        {
            ModelState.Clear();

            CommonResponseModel responseModel = new CommonResponseModel();

            try
            {
                string url = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"] + "Account/UserRegistration";
                var client = new RestClient(url);
                var request = new RestRequest(RestSharp.Method.POST) { RequestFormat = DataFormat.Json };
                request.AddHeader("Content-Type", "application/json");
                request.AddBody(ObjRegistrationModel);
                IRestResponse response = client.Execute(request);
                var statuscode = response.StatusCode;

                JavaScriptSerializer js = new JavaScriptSerializer();
                responseModel = js.Deserialize<CommonResponseModel>(response.Content);
                RegistrationModel registerresponseModel = new RegistrationModel();

                ViewBag.Message = responseModel.Message;
                return View("Index", ObjRegistrationModel);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Index", ObjRegistrationModel);
            }
        }

        //public RegistrationModel GetData()
        //{
        //    RegistrationModel responseModel = new RegistrationModel();

        //    try
        //    {
        //        string url = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"] + "Account/UserRegistration";
        //        var client = new RestClient(url);
        //        var request = new RestRequest(RestSharp.Method.GET) { RequestFormat = DataFormat.Json };
        //        request.AddHeader("Content-Type", "application/json");                
        //        IRestResponse response = client.Execute(request);
        //        var statuscode = response.StatusCode;

        //        JavaScriptSerializer js = new JavaScriptSerializer();
        //        responseModel = js.Deserialize<RegistrationModel>(response.Content);
        //        RegistrationModel registerresponseModel = new RegistrationModel();
        //    }
        //    catch (Exception ex)
        //    { }
        //}
    }
}