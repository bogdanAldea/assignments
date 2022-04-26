using Project.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ActivatablePowerSupply : IActivatablePowerSupply
    {
        public ActivatablePowerSupply(Utility utility)
        {
            Utility = utility;
        }

        public ActivatablePowerSupply()
        {

        }

        public int Id { get; set; }
        public Utility Utility { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsActive { get; set; }
    }
}
