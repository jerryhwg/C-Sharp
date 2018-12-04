﻿using System;
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
            //TwentyOneGame game = new TwentyOneGame(); // Instantiate the Class TwentyOneGame / game: instance (object)
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" }; // game: instance(object), Players: property (inheritance from Game class) / Instatiate with some values
            //game.ListPlayers(); // game: instance, ListPlayers: method (from Game class = super class)
            //game.Play();
            //Console.ReadLine();

            Deck deck = new Deck(); // instantiate class Deck / Deck: datatype, object, class / deck: instance for 'Shuffle' method
            deck.Shuffle(3); // deck: instance, Shuffle: method, 3: argument / access Shuffle in Deck class (class method)

            foreach (Card card in deck.Cards) // Card: datatype / foreach runs against a list, card exists only in this loop / list of deck.Cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // card.Face & card.Suit from Deck.cs
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
