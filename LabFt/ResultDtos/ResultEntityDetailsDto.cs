using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultEntityDetailsDto
    {
        public IList<ResultAdditionalInfoDto> AdditionalInfo { get; set; }
        public IList<ResultAddressDto> Addresses { get; set; }
        public IList<ResultAKADto> AKAs { get; set; }
        public string Comments { get; set; }
        public string DateListed { get; set; }
        public string EntityType { get; set; }
        public string Gender { get; set; }
        public IList<ResultIDDto> IDs { get; set; }
        public string ListReferenceNumber { get; set; }
        public ResultNameDto Name { get; set; }
    }
}
