using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Job
{
    public class InterviewDetails
    {
        public int JobId { get; set; }
        public DateTime? InterviewDateTime { get; set; }
        public string InterviewTime { get; set; }
        public string JobLocation { get; set; }
    }
}
