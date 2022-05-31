using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOneGame;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to basic card games demo. Can I get your name?");
            string playerName = Console.ReadLine();

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
                    catch (FraudException)
                    {
                        Console.WriteLine("That's not gonna fly.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error has occured. Please let someone know.");
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
    }
}
