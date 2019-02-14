using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card // this class defines/designs an object that will be used in the program
    {
        // create Constructor to assign default values upon creation
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        // 'public' makes this property accessible by other parts of the program
        public string Suit { get; set; } // allows to 'get' or 'set' this property
        public string Face { get; set; }

    }
}
