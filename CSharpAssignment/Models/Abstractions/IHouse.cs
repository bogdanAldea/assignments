using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstractions
{
    public interface IHouse : IHome
    {
        public bool HasYard { get; set; }
    }
}
