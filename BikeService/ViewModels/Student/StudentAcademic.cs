using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Student
{
    public class StudentAcademic
    {

        //public StudentAcademic()

        public int Id { get; set; }
        public int? StudentId { get; set; }

        [Required(ErrorMessage = " ")]
        public string StudentClass { get; set; }

        //[Required(ErrorMessage = " ")]
        //public int? BoardId { get; set; }

        public int? UniversityId { get; set; }

        [Required(ErrorMessage = " ")]
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Invalid year")]
        public int? PassingYear { get; set; }

        [Required(ErrorMessage = " ")]
        [Range(0.0, 100.0, ErrorMessage = "Invalid percentage.")]
        public string Percentage { get; set; }


        public string BoardName { get; set; }
        public string UniversityName { get; set; }


        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

    }
}
