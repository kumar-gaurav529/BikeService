using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblUserAddress
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int? City { get; set; }
        public int? State { get; set; }
        public int? Country { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? IsCurrentAddress { get; set; }
    }
}
