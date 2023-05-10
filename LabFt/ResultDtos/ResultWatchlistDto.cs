using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultWatchlistDto
    {
        public IList<ResultMatchDto> Matches { get; set; }
        public string Status { get; set; }
    }
}
