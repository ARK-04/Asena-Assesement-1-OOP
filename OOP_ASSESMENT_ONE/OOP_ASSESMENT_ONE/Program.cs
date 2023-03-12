using System;
using System.Collections.Generic;

namespace OOP_ASSESMENT_ONE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            do
            {
                Console.WriteLine("Would you like to test the program or use it - 1: Test  2: Use  3:End"); //check players desired type
                int desiredType = Convert.ToInt32(Console.ReadLine()); //store desired type

                if (desiredType == 1) //run the testing class
                {
                    Testing.fullTest(); //create testing pack
                }
                else if (desiredType == 2) //let user choose
                {
                    UserPlay();
                }
                else if (desiredType == 3) //ends if the player wants to end
                {
                    stop = true;
                }
                else
                {
                    Console.WriteLine("This is not an accepted value.");
                }
                Console.WriteLine('\n'); //new line for next loop
            } while (stop == false);
        }
        static void UserPlay()
        {
            Pack packObject = new Pack();
            Pack.makePack(); //make pack

            bool discardDeck = false; //checks that the user wants to continue
            do
            {
                Console.WriteLine("There are {0} cards in the deck \nEnter the number of your next move:\n1:Fisher-Yates Shuffle  2:Riffle Shuffle  3:No Shuffle  4:Deal one card  5:Deal multiple  6:End", Pack.deck.Count +1 );              
                int nextMove = Convert.ToInt32(Console.ReadLine()); //store next move

                if (nextMove < 4)//checks if it is a shuffle options
                {
                    Pack.shuffleCardPack(nextMove); //call the shuffle function
                }
                else if (nextMove == 4)//checks if it is deal one card
                {
                    Card dealt = Pack.deal(); //a singular card
                    Console.WriteLine("\nDealing one card: " + dealt.cardValue);
                }
                else if (nextMove == 5)//checks if it is a shuffle options
                {
                    Console.WriteLine("\nHow many cards would you like to deal:");
                    int amountToDeal = Convert.ToInt32(Console.ReadLine()); //store next move
                    List<string> dealing = Pack.dealCard(amountToDeal + 1);//multiple cards, with five as a example amount
                   
                    if (dealing[0] == "The deck is smaller than this value") //checks that it is cards that will be printed
                    {
                        Console.WriteLine("\nDealing {0} cards: ", amountToDeal);
                    }
                    foreach (var card in dealing) //print the results one value at a time
                    {
                        Console.Write(card + ", ");
                    }
                    Console.WriteLine("\n");
                }
                else if (nextMove == 6)//checks if it is end program
                {
                    discardDeck = true; //exit while
                }
                else //catches any ut of range options
                {
                    Console.WriteLine("This is not an accepted value.");
                }
            } while (discardDeck == false);
        }
    }
}
