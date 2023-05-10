using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt.ResultDtos
{
    public class ResultConflictsDto
    {
        public bool AddressConflict { get; set; }
        public bool CitizenshipConflict { get; set; }
        public bool CountryConflict { get; set; }
        public bool DOBConflict { get; set; }
        public bool EntityTypeConflict { get; set; }
        public bool GenderConflict { get; set; }
        public bool IDConflict { get; set; }
        public bool PhoneConflict { get; set; }
    }
}
