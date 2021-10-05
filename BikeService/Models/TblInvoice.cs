using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblInvoice
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsDiscount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
