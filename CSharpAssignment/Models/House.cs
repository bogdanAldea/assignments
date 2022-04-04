using Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class House : IHouse
    {
        public bool HasYard { get; set; }
        public int Number { get; set; }
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
        public int Id { get; set; }
    }
}
