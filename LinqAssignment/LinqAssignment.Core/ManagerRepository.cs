using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Core
{
    public class ManagerRepository
    {
   
        public IEnumerable<Manager> Create()
        {
            return new List<Manager>
            {
                new Manager {
                    Id = 1, TeamId = 1, FirstName = "Massimiliano", LastName = "Allegri", StyleOfPlay = "Horrible",
                    PreferedFormation = "God Knows what", Age = 54,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 6, 10), ContarctEnds = new DateOnly(2022, 6, 30)}
                },

                new Manager {
                    Id = 2, TeamId = 2, FirstName = "Jurgen", LastName = "Klop", StyleOfPlay = "Gegenpress",
                    PreferedFormation = "4-3-3", Age = 54,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2018, 6, 10), ContarctEnds = new DateOnly(2024, 6, 30)}
                },

                new Manager {
                    Id = 3, TeamId = 3, FirstName = "Thomas", LastName = "Tuchel", StyleOfPlay = "Direct",
                    PreferedFormation = "3-4-3", Age = 48,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2020, 6, 10), ContarctEnds = new DateOnly(2022, 6, 30)}
                },

                new Manager {
                    Id = 4, TeamId = 4, FirstName = "Xavi", LastName = "Hernandez", StyleOfPlay = "Tiki-Taka",
                    PreferedFormation = "4-3-3", Age = 42,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 10, 10), ContarctEnds = new DateOnly(2023, 6, 30)}
                },
            };
        }
    }
}
