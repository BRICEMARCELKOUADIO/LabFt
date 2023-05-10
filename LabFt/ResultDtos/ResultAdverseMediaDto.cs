using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultAdverseMediaDto
    {
        public string Description { get; set; }
        public IList<string> SubCategories { get; set; }
        public DateTime DateModified { get; set; }
    }
}
