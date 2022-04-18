using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsAssignment
{
    public class ApartmentEqualityComparer : IEqualityComparer<Apartment>
    {
        public bool Equals(Apartment apartmentA, Apartment apartmentB)
        {
            return apartmentA.NumberInBuilding == apartmentB.NumberInBuilding;
        }

        public int GetHashCode([DisallowNull] Apartment obj)
        {
            return obj.NumberInBuilding.GetHashCode();
        }
    }
}
