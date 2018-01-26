using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBDemo.Models
{
    public class Superhero
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SuperPower { get; set; }
        public bool TragicBackstory { get; set; }
        public bool PublicIdentity { get; set; }
    }
}
