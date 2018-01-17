using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Models
{
    public class Greeting
    {
        public string VisitorName { get; set; }

        public Greeting()
        {
        }

        public Greeting(string newname)
        {
            VisitorName = newname;
        }
    }
}
