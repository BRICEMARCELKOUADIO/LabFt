using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultRecordDetailsDto
    {
        public int AcceptListID { get; set; }
        public string AccountAmount { get; set; }
        public string AccountGroupID { get; set; }
        public string AccountOtherData { get; set; }
        public string AccountProviderID { get; set; }
        public string AccountMemberID { get; set; }
        public string AccountType { get; set; }
        public bool AddedToAcceptList { get; set; }
        public IList<ResultAdditionalInfoDto> AdditionalInfo { get; set; }
        public IList<ResultAddressDto> Addresses { get; set; }
        public string Division { get; set; }
        public string DPPA { get; set; }
        public string EFTType { get; set; }
        public string EntityType { get; set; }
        public string Gender { get; set; }
        public int GLB { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public ResultNameDto Name { get; set; }
        public ResultRecordStateDto RecordState { get; set; }
        public DateTime SearchDate { get; set; }
    }
}
