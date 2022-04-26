using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Apartment
    {
        public int UtilityIndex { get; set; }
        public int UtilityPayment { get; set; }

        public List<Utility> Utilities { get; set; } = new();

        public int CalculateTotalPayment(int price)
        {
            int totalPayment = 0;

            foreach (Utility utility in Utilities)
            {
                totalPayment += utility.IndexMeter * price;
            }

            return totalPayment;

        }

        public void CalculatePaymen(int utilityPrice)
        {
            if (utilityPrice < 1) { throw new ArgumentException(); }

            UtilityPayment = utilityPrice * UtilityIndex;
        }

        public void AddUtilityToAparment(Utility utility)
        {
            Utilities.Add(utility);
        }

    }
}
