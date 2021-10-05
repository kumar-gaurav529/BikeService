using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels
{
    public class Token
    {
        public string  TokenString { get; set; }
        public DateTime? ExpireOn { get; set; }
    }
}
