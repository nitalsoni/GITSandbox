using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITSandboxApp
{
    class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Abs(int a)
        {
            if (a < 1)
                return a * -1;
            else
                return a;
        }


        public int Mod(int a, int b)
        {
            return a % b;
        }
    }
}
