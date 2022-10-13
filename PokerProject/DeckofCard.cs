using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    internal class DeckofCard
    {
        //Random number object to share among Deck objects
        private static Random randomNum = new Random();

        private const int NumberOfCards = 52;
        private Card[] deck = new Card[NumberOfCards];
        public int currentCard = 0;

        //Constructor fills deck of cards
        public DeckofCard()
        {
            string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six",
                "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            //populate deck with Card objects

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(faces[i % 13], suits[i / 13]);
            }

        }//End of Deck()

        public void Shuffle()
        {
            currentCard = 0;
            //for each Card, pick another random Card and swap them
            for (var first = 0; first < deck.Length; first++)
            {
                //select a random number between 0 and 51
                var second = randomNum.Next(NumberOfCards);

                //Swap the cards
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }//End of shuffle()

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }//End of DealCard()
    }
}
