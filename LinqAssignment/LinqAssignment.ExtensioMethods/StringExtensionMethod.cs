using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.ExtensioMethods
{
    public static class StringExtensionMethod
    {
        public static string ChangeLetterCase(this string stringInput)
        {
            if (stringInput.Length > 0)
            {
                char[] chars = stringInput.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = char.IsUpper(chars[i]) ? char.ToLower(chars[i]) : char.ToUpper(chars[i]);
                }
                return new string(chars);
            }
            return stringInput;
        }
    }
}
