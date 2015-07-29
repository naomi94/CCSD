using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CCSD
{
    public class ClinicalCodesParser
    {
        public List<ClinicalCode> Parse(string filename)
        {
            var records = File.ReadAllLines(filename).Skip(1);

            var codes = new List<ClinicalCode>();

            foreach (var record in records)
            {
                var tokens = record.Split('\t');

                var code = new ClinicalCode();
                
                codes.Add(code);
            }

            return codes;
        }
    }
}
