using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to basic card games demo. Can I get your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much cash do you want to start with?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Well hey there, {0}, would you like to join a game of Blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOne();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing.");
            }
            
            Console.WriteLine("Right then, welp.. take care.");
            Console.ReadLine();
        }
    }
}
