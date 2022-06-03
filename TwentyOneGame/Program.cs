using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOneGame;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to basic card games demo. Can I get your name?");
            string playerName = Console.ReadLine();

            //From vid 395
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMsg + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            //From video 385 - Re: Error handling
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much cash do you want to start with?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please use numeric digits only, no decimals.");
            }

            Console.WriteLine("Well hey there, {0}, would you like to join a game of Blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();

                using (StreamWriter file = new StreamWriter(@"C:\Users\nylan\OneDrive\Desktop\21Logs.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOne();
                game += player;
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
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occured. Please let someone know.");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thanks for playing.");
            }
            
            Console.WriteLine("Right then, welp.. take care.");
            Console.ReadLine();
        }
        //DB connections
        private static void UpdateDBWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMsg, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMsg, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                cmd.Parameters.Add("@ExceptionMsg", SqlDbType.VarChar);
                cmd.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                cmd.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                cmd.Parameters["@ExceptionMsg"].Value = ex.Message;
                cmd.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"Select Id, ExceptionType, ExceptionMsg, Timestamp from Exceptions";
            List<ExceptionEntity> exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMsg = reader["ExceptionMsg"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    exceptions.Add(exception);
                }
                connection.Close(); 
            }
            return exceptions;
        }


    }
}
