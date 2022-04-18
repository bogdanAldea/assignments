using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsAssignment
{
    public class ApartmentComparer : IComparer<Apartment>
    {
        public int Compare(Apartment x, Apartment y)
        {
            if (Equals(x, y))
            {
                return 0;
            }
            return x.NumberInBuilding.CompareTo(y.NumberInBuilding);
        }
    }
}
