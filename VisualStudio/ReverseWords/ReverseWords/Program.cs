using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalWords;

            if (args.Any()) {
                originalWords = String.Join(" ", args);
            }
            else {
                originalWords = "The dog walks down the street";

            }

            ReverseTheWordsOption1(originalWords);
            ReverseTheWordsOption2(originalWords);
        }

        private static void ReverseTheWordsOption1(string originalWords)
        {
            char[] delimiterChars = { ' ', '\t' };

            var words = originalWords.Split(delimiterChars);
            var reversedWords = new StringBuilder();

            for (int x = words.Count() - 1; x >= 0; x--)
            {
                reversedWords.Append(words[x]);

                if (x > 0)
                {
                    reversedWords.Append(" ");
                }
            }

            Console.WriteLine("Method 1:\n\n");

            Console.WriteLine("Original text: '{0}'", originalWords);
            Console.WriteLine("Reversed text: '{0}'\n\n", reversedWords);
        }


        private static void ReverseTheWordsOption2(string originalWords)
        {
            char[] delimiterChars = { ' ', '\t' };

            var reversedWords = String.Join(" ", originalWords.Split(delimiterChars).Reverse());

            Console.WriteLine("Method 2:\n\n");

            System.Console.WriteLine("Original text: '{0}'", originalWords);
            System.Console.WriteLine("Reversed text: '{0}'\n\n", reversedWords);
        }
    }
}
