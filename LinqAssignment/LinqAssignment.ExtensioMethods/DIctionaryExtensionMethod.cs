using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.ExtensioMethods
{
    public static class DIctionaryExtensionMethod
    {
        public static void PrettyPrint(this IDictionary<string, string> dict)
        {
            foreach (KeyValuePair<string, string> items in dict)
            {
                Console.WriteLine($"{items.Key}: {items.Value}\n");
            }
        }
    }
}
