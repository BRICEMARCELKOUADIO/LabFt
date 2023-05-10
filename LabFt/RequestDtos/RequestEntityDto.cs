using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.RequestDtos
{
    public class RequestEntityDto
    {
        public string EntityType { get; set; }
        public RequestNameDto Name { get; set; }
        public IList<RequestAdditionalInfoDto> AdditionalInfo { get; set; }
        public IList<RequestAddressDto> Addresses { get; set; }
    }
}
