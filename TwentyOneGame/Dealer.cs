using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //Takes first card from deck
            Hand.Add(Deck.Cards.First());
            //Adds it to Hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            //Removes first card from Hand list (0 index)
            Deck.Cards.RemoveAt(0);

        }
    }
}
