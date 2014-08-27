using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           //loop through 35 times into the fizzbuzz function and print the output.
            for (int i = 1; i <= 35; i++)
            {
               //call the fizzbuzz function
                FizzBuzz(i);
            }
           //keep console open
            Console.ReadKey();
            {
                
            }
        }

       //fizzbuzz takes in a number and spits out a "fizzbuzz", "fizz", or "buzz"
        static void FizzBuzz(int num1)
        {
            //store input into variable number
            int number = num1;

            //check if the input is divisible by both 5 and 3
            if (number % 3 == 0 && number % 5 == 0)
            {
               //print fizzbuzz into the console
                Console.WriteLine("FizzBuzz");
            }

            //check if input is divisible by 5
            else if (number % 5 == 0)
            {
                //print fizz into the console
                Console.WriteLine("Fizz");
            }

            //check if input is divisible by 3
            else if (number % 3 == 0)
            {
                //print buzz into the console
                Console.WriteLine("Buzz");
            }

           //if input isn't divisible by either 5 or 3 just print the number
            else
            {
               //print the input number into the console
                Console.WriteLine(number);
            }

        }

    }
}
