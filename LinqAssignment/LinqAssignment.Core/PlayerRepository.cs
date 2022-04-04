using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Core
{
    public class PlayerRepository
    {
        public IEnumerable<Player> Create()
        {
            return new List<Player>
            {
                new Player
                {
                    Id = 1,
                    TeamId = 1,
                    FirstName = "Juan",
                    LastName = "Cuadrado",
                    Age = 33,
                    Position = FieldPosition.InsideForwardRight,
                    TransferMarketValue = 40000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 10, 10), ContarctEnds = new DateOnly(2024, 10, 9), Wage = 3200000 }
                },

                new Player
                {
                    Id = 2,
                    TeamId = 1,
                    FirstName = "Federico",
                    LastName = "Chiesa",
                    Age = 23,
                    Position = FieldPosition.InsideForwardLeft,
                    TransferMarketValue = 66000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 6, 10), ContarctEnds = new DateOnly(2025, 6, 9), Wage = 4000000 }
                },

                new Player
                {
                    Id = 3,
                    TeamId = 1,
                    FirstName = "Dusan",
                    LastName = "Vlahovic",
                    Age = 22,
                    Position = FieldPosition.Striker,
                    TransferMarketValue = 90000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2022, 2, 10), ContarctEnds = new DateOnly(2026, 6, 9), Wage = 6000000 }
                },

                new Player
                {
                    Id = 4,
                    TeamId = 1,
                    FirstName = "Paulo",
                    LastName = "Dybala",
                    Age = 29,
                    Position = FieldPosition.MidfielderAdvanced,
                    TransferMarketValue = 60000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2019, 6, 30), ContarctEnds = new DateOnly(2022, 7, 1), Wage = 7000000 }

                },

                new Player
                {
                    Id = 5,
                    TeamId = 1,
                    FirstName = "Leonardo",
                    LastName = "Bonucci",
                    Age = 34,
                    Position = FieldPosition.DefenderCenter,
                    TransferMarketValue = 30000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2019, 6, 30), ContarctEnds = new DateOnly(2022, 7, 1), Wage = 2000000 }
                },

                new Player
                {
                    Id = 6,
                    TeamId = 2,
                    FirstName = "Mohamed",
                    LastName = "Salah",
                    Age = 29,
                    Position = FieldPosition.InsideForwardRight,
                    TransferMarketValue = 60000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2019, 6, 30), ContarctEnds = new DateOnly(2023, 7, 1), Wage = 7000000 }
                },

                new Player
                {
                    Id = 7,
                    TeamId = 2,
                    FirstName = "Roberto",
                    LastName = "Firmino",
                    Age = 30,
                    Position = FieldPosition.Striker,
                    TransferMarketValue = 40000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 10, 10), ContarctEnds = new DateOnly(2024, 10, 9), Wage = 3200000 }
                },

                new Player
                {
                    Id = 8,
                    TeamId = 2,
                    FirstName = "Virgil",
                    LastName = "Van Dijk",
                    Age = 30,
                    Position = FieldPosition.DefenderCenter,
                    TransferMarketValue = 40000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 10, 10), ContarctEnds = new DateOnly(2024, 10, 9), Wage = 8000000 }
                },

                new Player
                {
                    Id = 9,
                    TeamId = 3,
                    FirstName = "Antonio",
                    LastName = "Rudiger",
                    Age = 29,
                    Position = FieldPosition.DefenderCenter,
                    TransferMarketValue = 30000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2020, 6, 30), ContarctEnds = new DateOnly(2026, 7, 1), Wage = 4000000 }
                },

                new Player
                {
                    Id = 10,
                    TeamId = 3,
                    FirstName = "N'Golo",
                    LastName = "Kante",
                    Age = 30,
                    Position = FieldPosition.MidfielderCenter,
                    TransferMarketValue = 55000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2020, 6, 30), ContarctEnds = new DateOnly(2023, 7, 1), Wage = 6000000 }
                },

                new Player
                {
                    Id = 11,
                    TeamId = 3,
                    FirstName = "Romelu",
                    LastName = "Lukaku",
                    Age = 28,
                    Position = FieldPosition.DefenderCenter,
                    TransferMarketValue = 35000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 6, 30), ContarctEnds = new DateOnly(2024, 6, 30), Wage = 5200000 }
                },

                new Player
                {
                    Id = 12,
                    TeamId = 4,
                    FirstName = "Marc-Andre",
                    LastName = "ter Stergen",
                    Age = 30,
                    Position = FieldPosition.GoalKepper,
                    TransferMarketValue = 35000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 6, 30), ContarctEnds = new DateOnly(2024, 6, 30), Wage = 5200000 }
                },

                new Player
                {
                    Id = 11,
                    TeamId = 3,
                    FirstName = "Riqui",
                    LastName = "Puig",
                    Age = 23,
                    Position = FieldPosition.MidfielderAdvanced,
                    TransferMarketValue = 40000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2021, 6, 30), ContarctEnds = new DateOnly(2024, 6, 30), Wage = 5200000 }
                },

                new Player
                {
                    Id = 11,
                    TeamId = 3,
                    FirstName = "Ansu",
                    LastName = "Fati",
                    Age = 20,
                    Position = FieldPosition.InsideForwardLeft,
                    TransferMarketValue = 45000000,
                    ContractDuration = new Contract { ContractStarts = new DateOnly(2020, 6, 30), ContarctEnds = new DateOnly(2025, 6, 30), Wage = 5200000 }
                },
            };
        }
    }
}
