using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //// EXAMPLE of Inheritance
            //Game game = new Game();
            //game.Players = new List<string>() { "Jesse", "Jefe", "Billy-Bob" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();


            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";

            //game = game + player; //// adds player to list using overloaded operator
            //game = game - player; //// removes player from list using overloaded operator
            //game += player; // shorthand for the code above
            //game -= player;

            Deck deck = new Deck();
            deck.Shuffle(3);
            //deck = Shuffle(deck: deck, times: 3); //  EXAMPLE of named parameters

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
