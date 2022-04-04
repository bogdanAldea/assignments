using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class QuantityIsNegativeException :  Exception
    {
        public QuantityIsNegativeException()
        {

        }

        public QuantityIsNegativeException(string message) : base(message)
        {

        }

        public QuantityIsNegativeException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
