using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstractions
{
    public interface IUtility : IEntity
    {
        public string Name { get; set; }
        public Provider Provider { get; set; }

        public double CalculatePayment();
    }
}
