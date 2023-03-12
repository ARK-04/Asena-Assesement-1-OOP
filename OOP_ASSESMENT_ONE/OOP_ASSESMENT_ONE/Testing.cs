using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_ONE
{
    //testing the program - it also gives access for later testing as the programmer can now call each one sepearatly while passing in the current pack
    internal class Testing
    {
        public static void fullTest() //does a full test of everything
        {
            Pack testPack = new Pack();
            Pack.makePack(); //populate a example pack

            testShuffle(); //cals the shuffle test
            testSingleDeal();//calls the single deal test
            testMultipleDeal(5); //calls the multi deal test with an example of 5
        }
        public static void testShuffle() //isolates shuffle test for use 
        {
            //Shuffle and print
            for (int i = 1; i < 4; i++) //looping over each shuffle so it can be printed each time
            {
                Pack.shuffleCardPack(i); //call the shuffle function

                //title the type of shuffle
                if (i == 1)
                {
                    Console.WriteLine("\nFisher-Yates Shuffle");
                    Console.WriteLine("----->");
                }
                else if (i == 2)
                {
                    Console.WriteLine("\nRiffle Shuffle");
                    Console.WriteLine("----->");
                }
                else if (i == 3)
                {
                    Console.WriteLine("\nNo Shuffle");
                    Console.WriteLine("----->");
                }

                foreach (var card in Pack.deck) //print the results one value at a time
                {
                    Console.WriteLine(card.cardValue);
                }
            }
        }
        public static void testSingleDeal() //isolates deal test
        {
            //Deal single card
            Card dealt = Pack.deal(); //a singular card
            Console.WriteLine("\nDealing one card: " + dealt.cardValue);
        }
        public static void testMultipleDeal(int amount) //isolate deal multi test
        {
            List<string> dealing = Pack.dealCard(amount);//multiple cards, with five as a example amount
            Console.WriteLine("\nDealing {0} cards: ", amount);
            foreach (var card in dealing) //print the results one value at a time
            {
                Console.Write(card + ", ");
            }
        }
    }
}
