using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_ONE
{
    internal class Pack
    {
        public static List<Card> deck = new List<Card>(); //create deck which will be filled
        public static void makePack()
        {
            for (int i = 1; i < 5; i++)//Suit values 1-4
            {
                for (int j = 1; j < 14; j++)//Card values 1-13 
                {
                    Card currentCard = new Card(i, j); // creates value
                    deck.Add(currentCard); //Adds value to deck
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            Random r = new Random();
            List<Card> shuffledDeck = new List<Card>();
            bool shuffled = false;

            if (typeOfShuffle == 1) //Fisher-Yates Shuffle
            {
                //Loops through the whole deck
                for (int i = deck.Count; i > 0; i--)
                {
                    //Randomly select one of the remaining unshuffled letters
                    int movingCardLocation = r.Next(0, i);

                    //Place the selected letter in the shuffled collect
                    shuffledDeck.Add(deck[movingCardLocation]);

                    //Remove the selected letter from the unshuffled collection
                    deck.RemoveAt(movingCardLocation);

                }
                deck = shuffledDeck; //now the shuffling has finsihed, the new deck can be placed into the deck
                shuffled = true; //returns the bool the client requested
            }
            else if (typeOfShuffle == 2)//Riffle Shuffle 
            {
                for (int i = 0; i < 7; i++) //seven times a riffle shuffle is the amount needed for a true random shuffle
                {
                    for (int j = 0; deck.Count > 0; j++) //runs through the deck until it is empty
                    {
                        shuffledDeck.Add(deck[0]); //take the first value of the deck
                        shuffledDeck.Add(deck[deck.Count / 2]); //take the value of the 'second half' of the deck
                                                                //removes both first values
                        deck.RemoveAt(0);
                        deck.RemoveAt(deck.Count / 2);
                    }
                    deck.AddRange(shuffledDeck); //place the shuffled deck back in the deck list
                    shuffledDeck.Clear(); //place the shuffled deck back in the deck list
                }
                shuffled = true; //returns the bool the client requested
            }
            else if (typeOfShuffle == 3) //no shuffle
            {
                shuffled = true; //returns the bool the client requested
            }
            return shuffled;//returns false if it has not shuffled
        }

        public static Card deal() //dealing one
        {
            Card dealingCard = deck.Last(); //store card before removing from deck
            deck.RemoveAt(deck.Count - 1);
            return dealingCard;
        }

        public static List<string> dealCard(int amount)//dealing multiple
        {
            List<string> dealingCards = new List<string>(); //create deck for dealt

            if (Pack.deck.Count < amount) //check the deck has enough cards
            {
                dealingCards.Add("The deck is smaller than this value"); //add to returning list of cards
            }
            else
            {
                for (int i = 1; i < amount; i++) //removes cards one by one
                {
                    Card dealingCard = deck.Last(); //store card before removing from deck
                    deck.RemoveAt(deck.Count - 1);
                    dealingCards.Add(dealingCard.cardValue); //add to returning list of cards
                }
            }
            return dealingCards;  
        }
    }
}
