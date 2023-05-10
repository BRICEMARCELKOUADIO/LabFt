using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public  class ResultRecordDto
    {
        public int Record { get; set; }
        public ResultRecordDetailsDto RecordDetails { get; set; }
        public long ResultID { get; set; }
        public int RunID { get; set; }
        public ResultWatchlistDto Watchlist { get; set; }
    }
}
