using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultMatchDto
    {
        public int AcceptListID { get; set; }
        public bool AddedToAcceptList { get; set; }
        public bool AddressName { get; set; }
        public bool AutoFalsePositive { get; set; }
        public bool BestAddressIsPartial { get; set; }
        public string BestCountry { get; set; }
        public int BestCountryScore { get; set; }
        public string BestCountryType { get; set; }
        public bool BestDOBIsPartial { get; set; }
        public string BestName { get; set; }
        public int BestNameScore { get; set; }
        public int CheckSum { get; set; }
        public ResultConflictsDto Conflicts { get; set; }
        public IList<ResultDOBDto> DOBs { get; set; }
        public ResultEntityDetailsDto EntityDetails { get; set; }
        public string EntityName { get; set; }
        public int EntityScore { get; set; }
        public string EntityUniqueID { get; set; }
        public bool FalsePositive { get; set; }
        public ResultFileDto File { get; set; }
        public bool GatewayOFACScreeningIndicatorMatch { get; set; }
        public object ID { get; set; }
        public bool MatchReAlert { get; set; }
        public ResultMatchXMLDto MatchXML { get; set; }
        public int PreviousResultID { get; set; }
        public string ReasonListed { get; set; }
        public DateTime ResultDate { get; set; }
        public bool SecondaryOFACScreeningIndicatorMatch { get; set; }
        public bool TrueMatch { get; set; }
        public IList<ResultRelationshipDto> Relationships { get; set; }
        public IList<ResultPEPDto> PEPs { get; set; }
        public IList<ResultEnforcementDto> Enforcements { get; set; }
        public IList<ResultAdverseMediaDto> AdverseMedias { get; set; }
        public IList<ResultSourceItemDto> SourceItems { get; set; }
        public DateTime DateModified { get; set; }
        public string Status { get; set; }
    }
}
