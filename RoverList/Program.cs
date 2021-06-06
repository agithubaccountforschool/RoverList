using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words


            string[] words = "zero one two three four five six seven eight nine ten eleven twelve thirteen fourteen fifteen".Split(' ');
            foreach(string word in words){
                list.Add(word);
            }

            /*list.Add("another");
            list.Add("yetAnother");
            list.Add(3,"before");*/


            // TODO:  Print out the list

            list.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            while (true)
            {
                string word = Console.ReadLine();
                if (word == "done") break;
                list.Add(word);
            }


            list.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            while (true)
            {
                string word = Console.ReadLine();
                if (word == "done") break;
                list.Add(0,word);
            }


            list.ListNodes();

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            for (int n = 1;true ;n++)
            {
                if(list.RemoveAt(n) == false)break;
            }


            list.ListNodes();

            // TODO:  Clear the list
            // TODO:  Print out the list

            while (true) { }

        }
    }
}
