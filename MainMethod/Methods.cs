using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Methods
    {
        // --- Original Work below, revision follows --
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public int Add(decimal c, decimal d)
        //{
        //    int f = Convert.ToInt32(c * d);
        //    return f;
        //}


        //public int Add(string g, string h)
        //{
        //    int i = Convert.ToInt32(g);
        //    int j = Convert.ToInt32(h);
        //    int k = i - j;
        //    return k;    
        //}


        //Revision work, methods of the same name to demonstrate overloaded methods 
        public int Add(int a)
        {
            return a + 2;
        }

        public int Add(decimal c)
        {
            int f = Convert.ToInt32(c * 2);
            return f;
        }

        public int Add(string g)
        {
            int i = Convert.ToInt32(g);
            int k = i - 2;
            return k;
        }




    }
}
