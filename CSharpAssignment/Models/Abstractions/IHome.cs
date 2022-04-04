using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstractions
{
    public interface IHome : IEntity
    {
        public int Number { get; set; }
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }

    }
}
