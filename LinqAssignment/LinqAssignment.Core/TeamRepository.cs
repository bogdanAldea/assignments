using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Core
{
    public class TeamRepository
    {
        
        public IEnumerable<Team> Create()
        {
            return new List<Team>
            {
                new Team { Id = 1, Name = "Juventus", League = Competition.Italy, TransferBudget = 50000000},
                new Team { Id = 2, Name = "Liverpool", League = Competition.England, TransferBudget = 88000000},
                new Team { Id = 3, Name = "Chelsea", League = Competition.England, TransferBudget = 120000000},
                new Team { Id = 4, Name = "Barcelona", League = Competition.Spain, TransferBudget = 48000000},
            };
        }
    }
}
