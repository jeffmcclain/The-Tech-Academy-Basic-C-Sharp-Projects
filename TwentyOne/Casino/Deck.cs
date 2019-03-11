using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        // 'Deck()' is a Constructor to assign values to an object
        // Constructors always go at the top of class, before the properties
        public Deck()
        {
            // constructor for cards
            Cards = new List<Card>();

            // this loops through and assigns each face a suit, creating the cards
            for (int i = 0; i < 13; i++) // loops through each Face value
            {
                for (int j = 0; j < 4; j++) // loops through each Face value once for each Suit
                {
                    Card card = new Card();
                    card.Face = (Face)i; // cast an integer to each face
                    card.Suit = (Suit)j; // cast an integer to each Suit
                    Cards.Add(card); // add each card to the 'Cards' list
                }
            }
        }

        public void Shuffle(int times = 1)
            {
                for (int i = 0; i < times; i++)
                {
                    List<Card> TempList = new List<Card>();
                    Random random = new Random();

                    while (Cards.Count > 0)
                    {
                        int randomIndex = random.Next(0, Cards.Count);
                        TempList.Add(Cards[randomIndex]);
                        Cards.RemoveAt(randomIndex);
                    }
                    Cards = TempList;
                }
            }

        
        // property defines/designs values for an object
        public List<Card> Cards { get; set; }
    }
}
