using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Student
{
    public class StudentModal
    {
        public int StudentId { get; set; }
        public string RegisterationId { get; set; }

        [Required(ErrorMessage =" "), StringLength(100, ErrorMessage = "Maximum of 100 characters are allowed")]
        public string StudentName { get; set; }

       // [Required(ErrorMessage = " ")]
        public string CourseCode { get; set; }

       // [Required(ErrorMessage = " ")]       
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid contact number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage =" "),DataType(DataType.Password), MinLength(6, ErrorMessage = "Password must be atleat 6 digit long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = " "),DataType(DataType.Password),Compare("Password",ErrorMessage ="Password did not match")]
        public string ConfirmPassword { get; set; }



        [/*Required(ErrorMessage = " "),*/DataType(DataType.EmailAddress, ErrorMessage = "Invalid email id")]
        public string EmailId { get; set; }


       // [Required(ErrorMessage = "Aadhar card required")]
        [RegularExpression(@"^[0-9]{12,12}$", ErrorMessage = "Invalid aadhar card number.")]
        public string AdharCard { get; set; }

        //[Required(ErrorMessage = "City Required")]
        public int? City { get; set; }


        //[Required(ErrorMessage = "Address Required")]
        [StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string Address { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid contact number")]
        public string ContactNo2 { get; set; }

        [StringLength(500, ErrorMessage = "Maximum of 500 characters are allowed")]
        public string Parents_Details { get; set; }

        [StringLength(100, ErrorMessage = "Maximum of 100 characters are allowed")]
        public string ParentName { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid contact number")]
        public string ParentContactNo { get; set; }

        public string ConfirmationLink { get; set; }
        public string Dob { get; set; }

        public int? CenterId { get; set; }
        public string Gender { get; set; }
        public string CenterName { get; set; }
        public string CityName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ProfilePicUrl { get; set; }
        public string PreferedStatesForJob { get; set; }

    }

    public class StudentRegistration
    {     
        [Required(ErrorMessage = " "), StringLength(100, ErrorMessage = "Maximum of 100 characters are allowed")]
        public string StudentName { get; set; }
        

        [Required(ErrorMessage = " ")]       
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid contact number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = " "), DataType(DataType.Password), MinLength(6, ErrorMessage = "Password must be atleat 6 digit long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = " "), DataType(DataType.Password), Compare("Password", ErrorMessage = "Password did not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = " "), DataType(DataType.EmailAddress, ErrorMessage = "Invalid email id")]
        public string EmailId { get; set; }

        public int[] PreferedStateForJob { get; set; }

       

        public string Dob { get; set; }
        public string Gender { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }

    }
      
}
