using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NIIT.Web.ViewModels
{
    public class ForgotPassword
    {


        [Required(ErrorMessage=" "),DataType(DataType.EmailAddress, ErrorMessage = "Invalid email id")]
        public string Email { get; set; }

        [Required(ErrorMessage =" ")]
        public string UserType { get; set; }
    }
}
