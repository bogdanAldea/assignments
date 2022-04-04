using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.ExtensioMethods
{
    public static class IntExtensionMethod
    {
        public static int Reverse(this int intInput)
        {
            int result = 0;
            while (intInput > 0)
            {
                result = result * 10 + intInput % 10;
                intInput /= 10;
            }

            return result;
        }
    }
}
