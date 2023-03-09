using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<string> deck = new List<string>(); //create deck which will be filled
        public static List<string> MakePack()
        {
            for (int i = 1; i < 5; i++)//Suit values 1-4
            {

                for (int j = 1; j < 14; j++)//Card values 1-13 
                {
                    Card currentCard = new Card(i, j); // creates value
                    deck.Add(currentCard.value); //Adds value to deck
                }
            }

            return deck;
        }

        public static void shuffleCardPack(int typeOfShuffle)
        {
            Random r = new Random();
            List<string> shuffledDeck = new List<string>();

            if (typeOfShuffle == 1) //Fisher-Yates Shuffle
            {
                //Loops through the whole deck
                for (int i = deck.Count; i> 0; i--)
                {
                    //Randomly select one of the remaining unshuffled letters
                    int movingCardLocation = r.Next(0, i);

                    //Place the selected letter in the shuffled collect
                    shuffledDeck.Add(deck[movingCardLocation]);

                    //Remove the selected letter from the unshuffled collection
                    deck.RemoveAt(movingCardLocation);

                }
                deck = shuffledDeck; //now the shuffling has finsihed, the new deck can be placed into the deck
            }
            else if(typeOfShuffle == 2)//Riffle Shuffle 
            { //CHECK IF IT SHOULD RIFFLE MORE THEN Once
                for (int i = 0; deck.Count > 0; i++) //runs through the deck until it is empty
                {
                    shuffledDeck.Add(deck[0]); //take the first value of the deck
                    shuffledDeck.Add(deck[deck.Count/2]); //take the value of the 'second half' of the deck
                    Console.WriteLine(deck[0] + deck[deck.Count / 2]); //CHECK THIS WORKER
                    deck.RemoveAt(0);
                    deck.RemoveAt(deck.Count / 2);
                }
                deck = shuffledDeck;
                //half deck
                //get first value of each deck and put on final deck
                //remove these values
                //loop this until the two packs are empty 
            }
            else
            {
                Console.WriteLine("This is not an accepted value."); //lets the player know that they have not chose an option
            }
        }
        //public static Card deal()
        //{
            //Deals one card

//        }


  //      public static List<Card> dealCard(int Amount)
    //    {
          //Deals the number of cards specified by 'amount'
        //}
    }
}
