using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblVendor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public string VendorImage { get; set; }
        public string VendorAadharNo { get; set; }
        public string VendorAadharImage { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int? City { get; set; }
        public int? State { get; set; }
        public int? Country { get; set; }
        public int? Isverified { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
