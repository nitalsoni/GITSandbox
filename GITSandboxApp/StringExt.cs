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

        public override string ToString()
        {
            return "StringExt";
        }

        public string FirstUpper(string s)
        {
            return s.ToUpper();
        }
    }
}
