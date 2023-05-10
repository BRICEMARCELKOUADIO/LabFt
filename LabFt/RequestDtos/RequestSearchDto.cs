using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.RequestDtos
{
    public class RequestSearchDto
    {
        public RequestClientContextDto ClientContext { get; set; }
        public RequestSearchConfigurationDto SearchConfiguration { get; set; }
        public RequestSearchInputDto SearchInput { get; set; }
    }
}
