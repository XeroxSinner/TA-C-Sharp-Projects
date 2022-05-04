﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-- Creating a new card from the class object Card
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //Card cardTwo = new Card();


            //-- Creating a new Deck object and adding a Card to the list
            //Deck deck = new Deck();
            //deck.Cards = new List<Card>();

            //deck.Cards.Add(cardOne);

            //-- Creating a deck with the constructor added to the Deck object class


            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.WriteLine(cardTwo.Face + " of " + cardTwo.Suit);

            //Instantiating a new deck
            Deck deck = new Deck();
            //Verifying... another foreach loop that will print each card
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}