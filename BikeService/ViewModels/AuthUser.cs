using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIIT.Web.ViewModels
{
    public class AuthUser
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
        public string RediectUrl { get; set; }
        public string RoleId { get; set; }

    }
}
