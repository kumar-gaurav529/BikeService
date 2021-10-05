using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Common
{
    public class UserFeedback
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }

        [Required]
        public int UserRoleId { get; set; }

        [Required(ErrorMessage = "Feedback is required"), StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string UserFeedbackText { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string UserName { get; set; }
        public string UserType { get; set; }
    }
}
