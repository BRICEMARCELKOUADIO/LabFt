using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultFileDto
    {
        public DateTime Build { get; set; }
        public bool Custom { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Published { get; set; }
        public string Type { get; set; }
    }
}
