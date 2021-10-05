using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.ViewModels.Student
{
    public class EditStudent
    {
        public StudentModal student { get; set; }
        public StudentAcademic Class10th { get; set; }
        public StudentAcademic Class12th { get; set; }
        public StudentAcademic Graduation { get; set; }
    }
}
