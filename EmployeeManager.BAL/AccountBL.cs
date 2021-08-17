using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.DAL.DataModel;
using EmployeeManager.Models.Utility;

namespace EmployeeManager.BAL
{
    public class AccountBL
    {
        public CommonResponseModel UserRegistration(RegistrationModel UserProfile)
        {
            CommonResponseModel commonReponseModel = new CommonResponseModel();

            try
            {
                using (EmployeeMasterEntities dbContext = new EmployeeMasterEntities())
                {
                    var CustomerValue = dbContext.EmployeeMasters.FirstOrDefault(c => c.UserName == UserProfile.UserName);
                    if (CustomerValue == null)
                    {
                        EmployeeMaster ObjUserMaster = new EmployeeMaster();
                        var count = dbContext.EmployeeMasters.Count();

                        ObjUserMaster.UserName = UserProfile.UserName;
                        Random generator = new Random();
                        UserProfile.Password = generator.Next(0, 100000000).ToString("D8");
                        ObjUserMaster.Password = Method.Encrypt(UserProfile.Password);
                        ObjUserMaster.FirstName = UserProfile.FirstName;
                        ObjUserMaster.LastName = UserProfile.LastName;
                        ObjUserMaster.Mobile = UserProfile.Mobile;
                        ObjUserMaster.Email = UserProfile.Email;
                        ObjUserMaster.Address = UserProfile.Address;
                        ObjUserMaster.CreatedBy = 1;
                        ObjUserMaster.CreationTime = Convert.ToDateTime(DateTime.Now);                       
                        dbContext.EmployeeMasters.Add(ObjUserMaster);
                        dbContext.SaveChanges();


                        commonReponseModel.Status = 1;
                        commonReponseModel.Message = "User Created Successfully";
                    }
                    else
                    {
                        commonReponseModel.Status = 1;
                        commonReponseModel.Message = "UserName already Exist";
                    }
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commonReponseModel;
        }
    }
}
