using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did your bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer =="y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player; // add player to game
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player; // remove player from game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.ReadLine();


            
        }




        //// use lambda fucntion 'Count()' to iterate through the 'deck', counting each 'Ace'
        //int count = deck.Cards.Count(x => x.Face == Face.Ace);

        //// use lambda fucntion 'Where()' to filter list for 'King' and add to 'newList'
        //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

        //List<int> numberList = new List<int>() { 1, 4, 5, 12, 634, 123 };

        //// us lambda functions together to create more complex statmements
        //int sum = numberList.Where(x => x > 10).Sum();

        //Console.WriteLine(sum);

        //// playing with structs
        //Card card1 = new Card();
        //Card card2 = card1;
        //card1.Face = Face.Eight;
        //card2.Face = Face.King;
        //Console.WriteLine(card1.Face);

        //deck = Shuffle(deck: deck, times: 3); //  EXAMPLE of naming parameters

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

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
    }
}
