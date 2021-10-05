using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblSubCategory
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryImage { get; set; }
        public string SubCategoryBanner { get; set; }
        public string SubCategoryDisplayName { get; set; }
        public string SubCategoryCode { get; set; }
        public string SubCategoryDescription { get; set; }
        public string SubCategoryTitle { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
