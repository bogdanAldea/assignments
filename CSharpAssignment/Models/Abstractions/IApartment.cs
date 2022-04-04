using Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IApartment : IHome
    {
        public int FloorNumber { get; set; }
    }
}
