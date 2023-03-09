using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gamePack = Pack.MakePack(); //Create deck

            //Shuffle
            Console.WriteLine("Enter the number of the shuffle you desire - 1: Fisher-Yates Shuffle  2: Riffle Shuffle  3: No Shuffle"); //check players desired shuffle
            int desiredShuffle = Convert.ToInt32(Console.ReadLine()); //store desiredshuffle
            Pack.shuffleCardPack(desiredShuffle); //call the shuffle function

   
            Console.ReadLine();
        
        }
     }
}
