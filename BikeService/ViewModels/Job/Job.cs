using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Job
{
    public class Job
    {
        public int Id { get; set; }

        [Required(ErrorMessage =" ")]
        public int? OrganizationId { get; set; }

        [Required(ErrorMessage =" "), StringLength(100, ErrorMessage = "Maximum of 100 characters are allowed")]
        [RegularExpression(@"^[a-zA-Z\s*]+$", ErrorMessage = "Only letters are allowed")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = " "), StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string JobProfile { get; set; }

        [Required(ErrorMessage = " ")]
        public string ExperienceRequired { get; set; }

        [Required(ErrorMessage = " ")]
        public string Ctc { get; set; }

        [Required(ErrorMessage = " "), StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string WorkLocation { get; set; }

        [Required(ErrorMessage = " "), StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string SkillSet { get; set; }

        [Required(ErrorMessage = " ")]
        public string JobTiming { get; set; }

       // [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        //[Required(ErrorMessage = "Start date is required")]        
        public DateTime? StartedDate { get; set; }

        // [Required(ErrorMessage = "End date is required")]
        
        public DateTime? EndDate { get; set; }

        public int? State { get; set; }

        public string KnownLanguage { get; set; }
        public string PreferredLanguage { get; set; }
        public string LanguageProficiency { get; set; }

        [StringLength(200, ErrorMessage = "Maximum of 200 characters are allowed")]
        public string InterviewLocation { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid contact number")]
        public string InterviewContactNo { get; set; }

        [StringLength(100, ErrorMessage = "Maximum of 100 characters are allowed")]
        public string InterviewContactPerson { get; set; }
        public DateTime? InterviewDateTime { get; set; }

        public string GenderPreference { get; set; }
        public string JobType { get; set; }

        [StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string RequiredQualification { get; set; }


        public int CreatedBy { get; set; }
        public int CreatedByRole { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string OrgnizationName { get; set; }
        public IEnumerable<SelectListItem> OrganizationList { get; set; }
        public byte? NoOfPosition { get; set; }

        public string InterviewTime { get; set; }

        public string StateName { get; set; }

        public bool? IsAppliedByUser { get; set; }
        public DateTime? AppliedOn { get; set; }

    }
}
