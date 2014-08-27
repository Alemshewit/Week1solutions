using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a new list of strings for a menu and populate it intially
            List<string> myMenue = new List<string>() 
            { "Pizza", "Taco", "Hummus", "Instant Potatoes", "Injera" };
    
            //add new items to myMenue
            myMenue.Add("Chicken");
            myMenue.Add("Beef stew");

            //remove things from the list myMenue
            myMenue.Remove("Pizza");
            myMenue.Remove("Hummus");

            //remove items from myMenu by index
            myMenue.RemoveAt(1);

            
            //loop through our items and display them
            for (int i = 0; i < myMenue.Count; i++)
            {
                Console.WriteLine(myMenue[i]);
            }

            for (int i = 0; i < myMenue.Count; i++)
            {
                //set a variable equal to the current item in our list
                string item = myMenue[i];
                //conver the item to lowercase and search it for the word twix
                if (item.ToLower().Contains("taco"))
                {
                    //found a twix, make it capitalized
                    Console.WriteLine(item.ToUpper());
                }

            }

            //Another Easier way of printing out an arrya 
            Console.WriteLine(string.Join(", ", myMenue));

            //Another way of printing out arrya items on new lines  
            Console.WriteLine(string.Join("\n", myMenue));
         
            //a string is an array of characters
            string text = "strings are the best kind";   

            //loop through text and print out the charcters one by one
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }

            //loop through the list again, to make twix pop
          


            //keep console open
            Console.ReadKey();
        }
    }
}
