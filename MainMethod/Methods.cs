using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Methods
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float c, float d)
        {
            float e = c * d;
            int f = (int)e;
            return f;
        }


        public int Add(string g, string h)
        {
            int i = Convert.ToInt32(g);
            int j = Convert.ToInt32(h);
            int k = i - j;
            return k;    
        }




    }
}
