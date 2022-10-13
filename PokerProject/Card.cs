using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    internal class Card
    {
        private string Face { get; }
        private string Suit { get; }


        //Two parameter constructor initializes cards face and suit
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        //return string representation of the card
        //override modifies preset c# method ToString 
        public override string ToString() => $"{Face} of {Suit}";
    }
}
