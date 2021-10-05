using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryBanner { get; set; }
        public string CategoryDisplayName { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryDescription { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
