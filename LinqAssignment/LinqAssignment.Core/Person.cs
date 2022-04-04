using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Core
{
    public class Person
    {
        public int Id { get; set; }

        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Contract ContractDuration { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
