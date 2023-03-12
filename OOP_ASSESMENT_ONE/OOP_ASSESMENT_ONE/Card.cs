using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_ONE
{
    public enum Suit //to set the suit of the card
    {
        Club = 1,
        Diamond = 2,
        Heart = 3,
        Spades = 4,
    }

    public enum Value //to set the value of the card
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    internal class Card
    {
        public string cardValue { get; }

        public String value
        { get { return cardValue; } }

        public Card(int packSuit, int packValue)
        {
            var suitText = (Suit)packSuit;
            var valueText = (Value)packValue;
            cardValue = (suitText + " " + valueText);
        }
    }
}
