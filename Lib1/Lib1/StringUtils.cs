using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
    public class StringUtils
    {
        public static int CharCount(string value)
        {
            if (value == null)
                throw new ArgumentNullException("Value is null");

            if (String.Equals(value.Trim(), String.Empty))
                throw new ArgumentException("Whitespace");

            return value.Length;
        }
    }
}
