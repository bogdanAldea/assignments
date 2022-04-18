using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsAssignment
{
    public class Apartment : IEntity
    {
        public Apartment(int numberInBuilding, IDictionary<string, decimal> utilityPayments)
        {
            NumberInBuilding = numberInBuilding;
            UtilityPayments = utilityPayments;
        }

        public int Id { get; set; }
        public int NumberInBuilding { get; set; }
        public string? Tenant { get; set; }
        public IDictionary<string, decimal> UtilityPayments { get; set; }
    }
}
