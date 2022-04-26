using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Abstractions
{
    public interface IActivatablePowerSupply : IMeasurable, IActivatable
    {
        public int Id { get; set; }
        public Utility Utility { get; set; }
    }
}
