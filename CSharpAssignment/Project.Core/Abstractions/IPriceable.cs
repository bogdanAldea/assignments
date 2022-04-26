using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Abstractions
{
    public interface IPriceable
    {
        public decimal Price { get; set; }
    }
}
