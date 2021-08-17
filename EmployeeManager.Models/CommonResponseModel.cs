using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public partial class CommonResponseModel
    {
        public String Message { get; set; }
        public int Status { get; set; }

    }
}
