using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>();

            dictionary.Add('a', "Armagnac");
            dictionary['b'] = "Bière";
            dictionary['c'] = "Champagne";

            foreach (KeyValuePair<char, string> mot in dictionary)
            {
                Console.WriteLine("{0}: {1}", mot.Key, mot.Value);
            }

            dictionary.Remove('c');

            foreach (KeyValuePair<char, string> mot in dictionary)
            {
                Console.WriteLine("{0}: {1}", mot.Key, mot.Value);
            }
        }
    }
}
