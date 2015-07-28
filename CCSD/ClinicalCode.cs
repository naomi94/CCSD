using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSD
{
    public class ClinicalCode
    {
        public int Code { get; set; }
        public string CodeDescription { get; set; }
        public string Chapter { get; set; }
        public string HistoricalNotes { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public List<int> CodingPrinciples { get; set; }
    }
}
