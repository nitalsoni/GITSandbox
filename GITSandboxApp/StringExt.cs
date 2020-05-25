using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITSandboxApp
{
    class StringExt
    {
        public string AltUpper(string s)
        {
            return s.ToUpper();
        }

        public string AltLower(string s)
        {
            return s.ToLower();
        }

        public override string ToString()
        {
            return "StringExt";
        }

        public string FirstUpper(string s)
        {
            return s.ToUpper();
        }

        public int FindHash(string s)
        {
            return s.GetHashCode();
        }
    }
}
