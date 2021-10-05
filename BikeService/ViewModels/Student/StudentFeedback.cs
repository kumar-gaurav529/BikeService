using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Student
{
    public class StudentFeedback
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Feedback is required"), StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string Feedback { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
