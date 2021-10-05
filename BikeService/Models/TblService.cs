using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblService
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? ServiceType { get; set; }
        public string ServiceName { get; set; }
        public string DisplayName { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public string Specification { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
