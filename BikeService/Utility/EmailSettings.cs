using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.Utility
{
    public class EmailSettings
    {
        public String Host { get; set; }
        public int Port { get; set; }
        public String SenderEmailId { get; set; }
        public String SenderPassword { get; set; }
        public String SenderName { get; set; }

        public String FromEmail { get; set; }
        public String ToEmail { get; set; }

        public String CcEmail { get; set; }
    }
}
