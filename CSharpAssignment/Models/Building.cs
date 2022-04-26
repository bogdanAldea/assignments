using Models.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Building : IEntity, IEnumerable<IApartment>
    {

        public Building()
        {

        }

        public Building(Address address, int capacity)
        {
            Address = address;
            Capacity = capacity;
        }

        public int Id { get; set; }
        public Address Address { get; set; }
        public int Capacity { get; set; }
        public List<IApartment> Apartments { get; set; } = new();
        public List<IMeasurableUtility> CentralizedPowerSupplies { get; private set; }
        public List<IUtility> CentralizedUtilities { get; set; }

        public void CreateApartments()
        {
            for (int apartmentLimit = 0; apartmentLimit < Capacity; apartmentLimit++)
            {
                Apartments.Add(new Apartment { Number = apartmentLimit + 1 });
            }
        }

        public void CreateCentralizedPowerSupplies()
        {
            string[] powerSupplies = new string[] { "Cold Water", "Hot Water", "Gas Power", "Heating Power", "Electricity" };

            foreach (string supply in powerSupplies)
            {
                IMeasurableUtility powerSupply = new CentralizedPowerSupply() { Name = supply };
                CentralizedPowerSupplies.Add(powerSupply);
            }

        }

        public IEnumerator<IApartment> GetEnumerator()
        {

            return Apartments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Apartment apartment)
        {
            Apartments.Add(apartment);
        }

    }
}
