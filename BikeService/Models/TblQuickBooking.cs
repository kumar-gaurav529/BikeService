using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblQuickBooking
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public int? City { get; set; }
        public int? VehicleType { get; set; }
        public int? Ccdetails { get; set; }
        public int? Models { get; set; }
        public DateTime? ServiceDate { get; set; }
        public int? TimeSlot { get; set; }
        public string Address { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
