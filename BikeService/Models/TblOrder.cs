using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblOrder
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ServiceId { get; set; }
        public int? SubSubCatId { get; set; }
        public string OrderNumber { get; set; }
        public int? SerialNumber { get; set; }
        public int? ServiceDate { get; set; }
        public int? ServiceTimeSlotId { get; set; }
        public decimal? ServiceInitialAmount { get; set; }
        public decimal? ServiceTotalAmount { get; set; }
        public decimal? ServiceDiscountAmount { get; set; }
        public decimal? ServiceOfferAmount { get; set; }
        public decimal? ServiceAmountPaidByUser { get; set; }
        public string Status { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
