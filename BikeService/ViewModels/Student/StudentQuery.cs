using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Student
{
    public class StudentQuery
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Title is required"),StringLength(200,ErrorMessage = "Maximum of 200 characters are allowed")]
        public string QueryTitle { get; set; }
        
        [Required(ErrorMessage ="Description is required"), StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string QueryDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
