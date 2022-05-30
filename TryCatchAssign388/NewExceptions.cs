using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssign388
{
    public class NewExceptions : Exception
    {
        public NewExceptions()
            : base() { }
        public NewExceptions(string message)
            : base(message) { }
    }
}
