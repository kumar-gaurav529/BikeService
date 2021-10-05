using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblBanner
    {
        public int Id { get; set; }
        public string BannerName { get; set; }
        public string BannerUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
