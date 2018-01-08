using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Greetings
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public Greetings(string name)
        {
            Id = 1;
            Content = "Hello, " + name + " Tourist!";
        }

        public Greetings()
        {
            Id = 1;
            Content = "Hello!";
        }
    }
}
