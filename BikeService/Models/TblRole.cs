﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BikeService.Models
{
    public partial class TblRole
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
