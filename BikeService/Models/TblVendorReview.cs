using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblVendorReview
    {
        public int Id { get; set; }
        public int? VendorId { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
