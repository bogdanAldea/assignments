using Project.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class SomeMasterSupply : IMasterPowerSupply, IBillable
    {
        public int Id { get; set; }
        public Utility Utility { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public decimal Price { get; set; }
        public bool AmountToPay { get; set; }
    }
}
