using Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CentralizedUtility : IUtility
    {
        public string Name { get; set; }
        public Provider Provider { get; set; }
        public int Id { get; set; }

        public double CalculatePayment()
        {
            throw new NotImplementedException();
        }
    }
}
