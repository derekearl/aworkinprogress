//Team: AWorkInProgress
//Members: Logan Ray, Derek Earl, Vishnu Soranam, Celeste Wilkey


//Class Scripture: Behavior that is specific to Scriptures is all done by this class, not in other places in the program. 
//And, this class does not include items or behaviors that do not pertain to it.

//Class Word: A class is present that encapsulates the responsibilities of a Word (including that the Word class is responsible for storing 
//it's own shown/hidden state). Behavior that is specific to Words is all done by this class, not in other places in the program. And, this 
//class does not include items or behaviors that do not pertain to it.

//Class Reference: A class is present that encapsulates the responsibilities of a Reference (including handling multiple verses). Behavior that 
//is specific to References is all done by this class, not in other places in the program. And, this class does not include items or behaviors 
//that do not pertain to it.

using System;
using System.Collections.Generic;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the reference for the scripture: ");
            string dereference = Console.ReadLine();
            Console.WriteLine("Enter the text for the scripture: ");
            string text = Console.ReadLine();
            string input = "";
            cwScripture cwscripture = new cwScripture(dereference, text);
            cwscripture.cwDisplayScripture();

            while (!cwscripture.vsAllWordsHidden())
            {
                Console.WriteLine("Press enter to hide more words or type 'quit' to exit");
                input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                cwscripture.HideWords(1);
                Console.Clear();
                cwscripture.cwDisplayScripture();
            }
                if(input.ToLower() != "quit")
                {
                    Console.WriteLine("Congrats you did it!");
                }
                else
                {
                   Console.WriteLine("Don't give up try again!"); 
                }
        }
    }

    class cwScripture
    {
        private string deReference;
        private string detext;
        private List<string> lrWords;
        private List<bool> lrIsHidden;

        public cwScripture(string reference, string text)
        {
            this.deReference = reference;
            this.detext = text;
            lrWords = new List<string>(text.Split(" "));
            lrIsHidden = new List<bool>(new bool[lrWords.Count]);
        }

        public void cwDisplayScripture()
        {
            Console.WriteLine(deReference);
            for (int i = 0; i < lrWords.Count; i++)
            {
                if (lrIsHidden[i])
                {
                    Console.Write("____ ");
                }
                else
                {
                    Console.Write(lrWords[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public void HideWords(int count)
        {
            int hidden = 0;
            while (hidden < count && hidden < lrWords.Count)
            {
                int index = (new Random()).Next(lrWords.Count);
                if (!lrIsHidden[index])
                {
                    lrIsHidden[index] = true;
                    hidden++;
                }
            }

            if (lrWords.Count == 1 && !lrIsHidden[0])
            {
                lrIsHidden[0] = true;
            }
        }

        public bool vsAllWordsHidden()
        {
            foreach (bool hidden in lrIsHidden)
            {
                if (!hidden)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
