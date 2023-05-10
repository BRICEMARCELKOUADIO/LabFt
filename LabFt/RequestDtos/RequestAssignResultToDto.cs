using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.RequestDtos
{
    public class RequestAssignResultToDto
    {
        public string Division { get; set; }
        public string EmailNotification { get; set; }
        public IList<string> RolesOrUsers { get; set; }
        public string Type { get; set; }
    }
}
