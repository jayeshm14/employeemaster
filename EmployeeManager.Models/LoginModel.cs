using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public partial class LoginModel
    {
        [Required(ErrorMessage ="Please Enter User Name.")]
        public String UserName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        [Required(ErrorMessage = "Please Enter User Name.")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public String Mobile { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String ProfilePhoto { get; set; }

    }
}
