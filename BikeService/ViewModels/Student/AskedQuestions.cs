using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Student
{
    public class AskedQuestions
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Required Field")]
        public bool? RotationalShift { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public bool? Relocate { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public string Experience { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public string JobType { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [StringLength(100)]
        public string DesiredField { get; set; }

        public DateTime? Created_Date { get; set; }

    }
}
