using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    internal class Card
    {
        public string Face { get; }
        public string Suit { get; }

        public int faceintVal {get; set;}


        //Two parameter constructor initializes cards face and suit
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
            if (Face == "Ace")
            {
                faceintVal = 1;
            }
            else if (Face == "Deuce")
            {
                faceintVal = 2;
            }
            else if (Face == "Three")
            {
                faceintVal = 3;
            }
            else if (Face == "Four")
            {
                faceintVal = 4;
            }
            else if (Face == "Five")
            {
                faceintVal = 5;
            }
            else if (Face == "Six")
            {
                faceintVal = 6;
            }
            else if (Face == "Seven")
            {
                faceintVal = 7;
            }
            else if (Face == "Eight")
            {
                faceintVal = 8;
            }
            else if (Face == "Nine")
            {
                faceintVal = 9;
            }
            else if (Face == "Ten")
            {
                faceintVal = 10;
            }
            else if (Face == "Jack")
            {
                faceintVal = 11;
            }
            else if (Face == "Queen")
            {
                faceintVal = 12;
            }
            else if (Face == "King")
            {
                faceintVal = 13;
            }
        }

        //return string representation of the card
        //override modifies preset c# method ToString 
        public override string ToString() => $"{Face} of {Suit}";
    }
}
