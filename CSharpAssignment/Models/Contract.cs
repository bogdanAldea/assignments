using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contract
    {
        public DateOnly ContractStarts { get; set; }
        public DateOnly ContractEnds { get; set; }
        public double ServicePrice { get; set; }
    }
}
