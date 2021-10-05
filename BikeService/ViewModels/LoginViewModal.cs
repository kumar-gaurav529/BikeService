using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels
{
    public class LoginViewModal
    {
        [Required(ErrorMessage =" ")]
        public string Id { get; set; }

        [Required(ErrorMessage = " "), DataType(DataType.Password)]
        public string  Password { get; set; }       
    }
}
