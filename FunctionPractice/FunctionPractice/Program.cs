using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {

       /*
        * three /// get you to summarized commenting
        * ctrl kc blocks out a code block
        * 
        */ 
        static void Main(string[] args)
        {
            //call the function     
            HelloWorld();

           Greeting("alem");

           //return double the given number
           int myAgeDoubled = DoubleIt(4);
           Console.WriteLine(myAgeDoubled);
           Console.WriteLine(DoubleIt(myAgeDoubled));

            // call multiply
            Console.WriteLine(Multiply(myAgeDoubled, 4));

            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine(Multiply(i, 3));

            }

            //keep console open
            Console.ReadKey();
        }
        
        static void HelloWorld() 
        {
            //write Hello World to the console
            Console.WriteLine("Hello World");
        }

        static void Greeting(string name)
        {
            Console.WriteLine("Good after noon " + name);
        }

        static int DoubleIt(int num)
        {
            return num * 2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
