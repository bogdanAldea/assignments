using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Core
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Competition League { get; set; }
        public double TransferBudget { get; set; }
    }

    public enum Competition
    {
        Italy,
        Spain,
        England,
    }
}
