using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //
            FindALetter("i", "The United States of America");

            WordCounter("and", "creat a new function and to loop over and the letter and  of of a string, and count and the number of a certain letter");

            //keep console open
            Console.ReadKey();
        }

        //creat a new function to loop over the letter of of a string, and count the number of a certain letter
        static void FindALetter(string lettertoFind, string text)
        {
            //declare a variable to hold the # of letter matches
            int letterCount = 0;

            //loop ove the string
            for (int i = 0; i < text.Length; i++)
            {
                //get the current letter in our loop
                string letter = text[i].ToString();

                //cover both the letter and letterToFind to lowercase
                if(letter.ToLower() == lettertoFind.ToLower())
                {
                    //found a letter, increment our counter
                    letterCount += 1;
                }
                
            }
            //time to display output
            Console.WriteLine("Found " + letterCount + " " + lettertoFind + "'s in " + text + ".");
        }

        //create a function to loop over words string
        static void WordCounter(string wordToFind, string text)
        {
            //count the number of words found
            int wordCount = 0;

            //split the string into words
            //and convert the array to a list for ease of use
            List<string> word = text.Split(' ').ToList();

            for (int i = 0; i < word.Count; i++)
            {
                //get the current word in our loop
                string item = word[i];

                //
                if (item.ToLower() == wordToFind.ToLower())
                {
                    wordCount += 1;
                }
            }

            Console.WriteLine("Found " + wordCount + " " + wordToFind + "'s in " + text + ".");
        }
    }
}
