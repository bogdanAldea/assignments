using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Core
{
    public class Player : Person
    {
        public FieldPosition Position { get; set; }
        public double TransferMarketValue { get; set; }
    }

    public enum FieldPosition
    {
        GoalKepper,
        DefenderRight,
        DefenderLeft,
        DefenderCenter,
        DefensiveMidfielder,
        MidfielderLeft,
        MidfielderRight,
        MidfielderCenter,
        MidfielderAdvanced,
        InsideForwardLeft,
        InsideForwardRight,
        Striker
    }
}
