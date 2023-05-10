using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultSearchDto
    {
        public string ClientReference { get; set; }
        public IList<ResultRecordDto> Records { get; set; }
        public string SearchEngineVersion { get; set; }
    }
}
