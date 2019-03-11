using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            // constant string variable
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            // catch input format exception (if user inputs non-integer characters)
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer =="y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid(); // create Guid (Global User ID) each time a new player is created
                using (StreamWriter file = new StreamWriter(@"C:\Users\Jefe\logs\log.txt", true))
                {
                    file.WriteLine(player.Id); // log the Guid 
                }
                Game game = new TwentyOneGame();
                game += player; // add player to game
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; // ends program when in a void method
                    }
                }
                game -= player; // remove player from game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = " +
                "TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; " +
                "TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover" +
                " = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) " +
                "VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = " +
                "TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; " +
                "TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover" +
                " = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;

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
