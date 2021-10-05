using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.Utility
{
    public class SmsTemplates
    {

        public int id { get; set; }
        public string body { get; set; }
        public string title { get; set; }
        public string senderName { get; set; }
        public string isMyDND { get; set; }

    }

    public class SmsTemplatesList
    {
        public List<SmsTemplates> templates { get; set; }
        public string status { get; set; }

    }
}
