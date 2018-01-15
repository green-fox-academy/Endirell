using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public int TimesLoaded { get; set; }

        public Greeting()
        {
            Id = 1;
            Content = "Hellokah!";
        }

        public Greeting(string name)
        {
            Id = 1;
            Content = "Hellokah " + name + "!";
            TimesLoaded = 1;
        }
    }
}
