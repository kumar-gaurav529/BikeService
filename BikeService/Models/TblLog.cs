using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblLog
    {
        public int Id { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionSource { get; set; }
        public DateTime? LogDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
