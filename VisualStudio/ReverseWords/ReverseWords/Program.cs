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
            ReverseTheWordsOption1();
        }

        private static void ReverseTheWordsOption1()
        {
            char[] delimiterChars = { ' ', '\t' };
            const string text = "The dog walks down the street";

            var words = text.Split(delimiterChars);
            var reversedWords = new StringBuilder();

            for (int x = words.Count() - 1; x >= 0; x--)
            {
                reversedWords.Append(words[x]);

                if (x > 0)
                {
                    reversedWords.Append(" ");
                }
            }

            System.Console.WriteLine("Original text: '{0}'\n", text);
            System.Console.WriteLine("Reversed text: '{0}'", reversedWords);
        }
    }
}
