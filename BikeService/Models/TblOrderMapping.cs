using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblOrderMapping
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? AssignTo { get; set; }
        public DateTime? AssignDate { get; set; }
        public string OrderCurrentStatus { get; set; }
        public string UserDescription { get; set; }
        public string VendorDescription { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public decimal? PaidAmount { get; set; }
        public int? PaymentReceivedBy { get; set; }
        public string AcceptOrderRemarks { get; set; }
        public int? AcceptOrderByVendorId { get; set; }
        public DateTime? AcceptOrderDate { get; set; }
        public int? IsReassigned { get; set; }
        public int? IsOrderAcceprByVendor { get; set; }
        public DateTime? OrderCompleteDate { get; set; }
        public int? OrderCompleteByVendorId { get; set; }
        public string OrderCompletedRemarksByVendor { get; set; }
        public int? IsOrderCancelled { get; set; }
        public DateTime? OrderCancelledDate { get; set; }
        public string OrderCancelledRemarks { get; set; }
        public string OrderCancellBy { get; set; }
        public string Status { get; set; }
        public int? VedorId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
