using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Core
{
    public class Contract
    {
        public DateOnly ContractStarts { get; set; }
        public DateOnly ContarctEnds { get; set; }
        public double Wage { get; set; }

        public override string ToString()
        {
            return $"{ContractStarts.ToString()} to {ContarctEnds.ToString()}";
        }
    }
    
}
