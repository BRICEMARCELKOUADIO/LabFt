using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultRecordStateDto
    {
        public bool AddedToAcceptList { get; set; }
        public string AlertState { get; set; }
        public IList<string> AssignedTo { get; set; }
        public string AssignmentType { get; set; }
        public string Division { get; set; }
        public IList<ResultHistoryDto> History { get; set; }
        public IList<ResultMatchStateDto> MatchStates { get; set; }
        public string Status { get; set; }
    }
}
