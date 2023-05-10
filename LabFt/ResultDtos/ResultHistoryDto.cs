using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultHistoryDto
    {
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
    }
}
