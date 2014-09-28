using System;
using System.Linq;
using System.Text;

namespace ReverseWords
{
    class Program
    {
        static readonly char[] DelimiterChars = { ' ', '\t' };

        static void Main(string[] args)
        {
            var originalSentence = args.Any() ? String.Join(" ", args) : "The dog walks down the street";

            ReverseTheWordsOption1(originalSentence);
            ReverseTheWordsOption2(originalSentence);
            ReverseTheWordsOption3(originalSentence);
            ReverseTheWordsOption4(originalSentence);
        }


        private static void ReverseTheWordsOption1(string originalSentence)
        {

            var words = originalSentence.Split(DelimiterChars);
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

            Console.WriteLine("Original text: '{0}'", originalSentence);
            Console.WriteLine("Reversed text: '{0}'\n\n", reversedWords);
        }


        private static void ReverseTheWordsOption2(string originalWords)
        {
            var reversedWords = String.Join(" ", originalWords.Split(DelimiterChars).Reverse());

            Console.WriteLine("Method 2:\n\n");

            Console.WriteLine("Original text: '{0}'", originalWords);
            Console.WriteLine("Reversed text: '{0}'\n\n", reversedWords);
        }

        private static void ReverseTheWordsOption3(string originalWords)
        {
            var listOfOrginalWords = originalWords.Split(DelimiterChars);
            var reversedWords = new StringBuilder();

            for (var wordCount = 0; wordCount < listOfOrginalWords.Count(); wordCount++) {
                var currentWord = listOfOrginalWords[wordCount];

                for (var letterCount = currentWord.Length - 1; letterCount >= 0; letterCount--)
                {
                    reversedWords.Append(currentWord[letterCount]);
                }

                if (wordCount < listOfOrginalWords.Count() - 1) {
                    reversedWords.Append(" ");
                }
            }

            Console.WriteLine("Method 3:\n\n");

            Console.WriteLine("Original text: '{0}'", originalWords);
            Console.WriteLine("Reversed text: '{0}'\n\n", reversedWords);
        }


        private static void ReverseTheWordsOption4(string originalWords)
        {
            var listOfOrginalWords = originalWords.Split(DelimiterChars);
            var reversedWords = new StringBuilder();

            foreach (var currentWord in listOfOrginalWords)
            {
                for (var letterCount = currentWord.Length - 1; letterCount >= 0; letterCount--)
                {
                    reversedWords.Append(currentWord[letterCount]);
                }
                reversedWords.Append(" ");
            }

            Console.WriteLine("Method 4:\n\n");

            System.Console.WriteLine("Original text: '{0}'", originalWords);
            System.Console.WriteLine("Reversed text: '{0}'\n\n", reversedWords.ToString().Trim());
        }
    }
}
