using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultEnforcementDto
    {
        public string Country { get; set; }
        public string Source { get; set; }
        public IList<string> SubCategories { get; set; }
        public DateTime DateModified { get; set; }
    }
}
