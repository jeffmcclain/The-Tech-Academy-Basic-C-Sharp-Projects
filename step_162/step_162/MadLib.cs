using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_162
{
    public class MadLib
    {

        

        public MadLib(string name, string place, string verb, string noun, string adjective)
        {
            Name = name;
            Place = place;
            Verb = verb;
            Noun = noun;
            Adjective = adjective;
        }

        public MadLib(string name) : this(name, "Moon", "shooting", "star", "clear")
        {
        }

        public string Name { get; set; }
        public string Place { get; set; }
        public string Noun { get; set; }
        public string Verb { get; set; }
        public string Adjective { get; set; }

    }
}
