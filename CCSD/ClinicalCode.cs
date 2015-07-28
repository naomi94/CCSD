using System.Collections.Generic;

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
