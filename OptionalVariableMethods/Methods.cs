using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalVariableMethods
{
    public class Methods
    {
        public int Add(int a, int b = 2)
        {
            return a + b;
        }
    }
}
