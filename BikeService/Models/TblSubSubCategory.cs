using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblSubSubCategory
    {
        public int Id { get; set; }
        public int? SubCategoryId { get; set; }
        public string SubSubCategoryName { get; set; }
        public string SubSubCategoryImage { get; set; }
        public string SubSubCategoryBanner { get; set; }
        public string SubSubCategoryDisplayName { get; set; }
        public string SubSubCategoryCode { get; set; }
        public string SubSubCategoryDescription { get; set; }
        public string SubSubCategoryTitle { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
