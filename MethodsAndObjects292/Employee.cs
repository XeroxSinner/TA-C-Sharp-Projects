using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects292
{
    //Creates class with properties inherited from Person class, adds Employee only property ID
    public class Employee : Person

    {
        public int Id { get; set; }
    }
}
