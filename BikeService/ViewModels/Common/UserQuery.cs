using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Common
{
    public class UserQuery
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }

        [Required]
        public int UserRoleId { get; set; }

        [Required(ErrorMessage = "Title is required"), StringLength(200, ErrorMessage = "Maximum of 200 characters are allowed")]
        public string QueryTitle { get; set; }

        [Required(ErrorMessage = "Description is required"), StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string QueryDescription { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string UserName { get; set; }
        public string UserType { get; set; }
        public string UserEmail { get; set; }

    }
}
