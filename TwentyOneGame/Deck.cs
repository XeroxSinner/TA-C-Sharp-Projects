using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Deck
    {
        //Constructor - A method that's called as soon as the object is created, method name is always the same as the class

        //Here's one way to create a default constructor (default properties when the class object is called elsewhere)
        //public Deck()
        //{
        //    Cards = new List<Card>();
        //    Card cardOne = new Card();
        //    cardOne.Face = "Two";
        //    cardOne.Suit = "Hearts";
        //    Cards.Add(cardOne);
        //}
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Spades", "Hearts", "Diamonds" };
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            //Using a nested foreach loop of the lists above to generate a full deck of cards
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        //
        public List<Card> Cards { get; set; }

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



    }
}
