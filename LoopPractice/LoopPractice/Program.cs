using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the loop function
        //    WhileLoopTest();
            FlipCoin(100);
         //   CoinFlip100Times();
           // CoinFlip(1000);

            //keep console open
            Console.ReadKey();
        }

        //functions go here..
        //static void WhileLoopTest()
        //{
        //    //while loop from 1 =>10
        //    int i = 1;

        //    //declare our incrementor
        //    while(i <= 10)
        //    {
        //        //write to console results of loop
        //        Console.WriteLine(i);

        //        //make sure to increment
        //        i++;
        //    }

        //}

        static void CoinFlip100Times()
        {
            //declare variables for our outcome holders
            int countHeads = 0;
            int countTails = 0;

            //random number generator...an instance of the random class..a constructor
            //to flip our coin
            Random rng = new Random();

            for (int i = 0; i < 100; i++)
            {
                //flip that coin
                int flip = rng.Next(0, 2);

                if (flip == 0)
                {
                    //it was heads, increase our counter
                    countHeads = countHeads + 1;
                }
                else
                {
                    //it was tails, inrease our counter
                    countTails = countTails + 1;
                }
            }
            Console.WriteLine("Number of heads: " + countHeads);
            Console.WriteLine("Number of tails: " + countTails);
        }

        static void CoinFlip(int flips)
        {
            //declare variables for our outcome holders
            int countHeads = 0;
            int countTails = 0;

            //random number generator...an instance of the random class..a constructor
            //to flip our coin
            Random rng = new Random();

            for (int i = 0; i < flips; i++)
            {
                //flip that coin
                int flip = rng.Next(0, 2);

                if (flip == 0)
                {
                    //it was heads, increase our counter
                    countHeads = countHeads + 1;
                }
                else
                {
                    //it was tails, inrease our counter
                    countTails = countTails + 1;
                }
            }

            //output the number of heads
            Console.WriteLine("Number of heads: " + countHeads);
            Console.WriteLine("Number of tails: " + countTails);
            
        }

        static void FlipCoin(int numHeads)
        {
            //declare variables for our outcome holders
            int headFlipped = 0;
            int totalFlips = 0;

            //random number generator...an instance of the random class..a constructor
            //to flip our coin
            Random rng = new Random();

            //do while loop until desired number of heads achieved 
            while(numHeads != headFlipped)
            {
                int flipped = rng.Next(0, 2);
                if (flipped == 0)
                {
                    headFlipped++;  
                }

                totalFlips++;
            }

            Console.WriteLine("It took " + totalFlips + " flips to get " + numHeads + " heads");

        }
    }
}
