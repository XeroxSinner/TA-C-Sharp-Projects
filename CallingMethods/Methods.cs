using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Methods
    {
        public int addTo(int num1)
        {
            int methNum1 = num1 + 1;
            return methNum1;
        }

        public int multi(int multiNum1)
        {
            int multiNum2 = multiNum1 * 2;
            return multiNum2;
        }

        public int subFrom(int subNum1)
        {
            int subNum2 = subNum1 - 3;
            return subNum2;
        }
    }
}
