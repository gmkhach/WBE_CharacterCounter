/**
 * Write a function that accepts a string, counts all occurrences of each character in that string, then returns a dictionary containing those counts
 * Order of the dictionary does not matter
 * ie: "test" should return {'t':2, 'e':1, 's':1}
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a test string\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    Console.Write($"\nCount report: ");
                    foreach (var x in CharacterCounter(input))
                    Console.Write("{0}-{1} ", x.Key, x.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\n\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static Dictionary<char, int> CharacterCounter(string input)
        {
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            foreach (var ch in input)
            {
                if (myDictionary.ContainsKey(ch))
                {
                    // accessing and incrementing the value of ch using ch as an index
                    myDictionary[ch]++;
                }
                else
                {
                    // adding a new dictionary item
                    myDictionary.Add(ch, 1);
                }
            }
            return myDictionary;
        }
    }
}
