using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    public static class WordChain
    {
        private static int operations = 0;

        public static int LongestChain(List<string> words)
        {
            var result = 0;

            var testWords = words
                .OrderByDescending(x => x.Length)
                .ToList();

            var maxLen = testWords[0].Length;

            Console.WriteLine($"max len = {maxLen}");

            var wordsToWork = testWords?
                .Where(x => x.Length >1)
                .ToList();

            var shorterWords = testWords?
                .Where(x => x.Length < maxLen)
                .ToList();

            foreach (var word in wordsToWork)//first loop with longest words
            {
                TestWordChain(word, shorterWords, ref result);

                if (word.Length <= result)
                    break;
            }

            return result;
        }

        private static bool TestWordChain(string word, List<string> testWords,  ref int currentResult)
        {
            Console.WriteLine($"--- {word}");

            var currentLength = word.Length;
            
            var shorterWords = testWords?
                .Where(x => x.Length < currentLength)
                .ToList();
            
            for (var i = 0; i < word.Length; i++)
            {
                var wordTest = $"{word.Substring(0, i)}{word.Substring(i + 1)}";
                

                if (shorterWords.Contains(wordTest))
                {
                    Console.WriteLine($"---- {wordTest}");

                    if (wordTest.Length == 1)
                        return (true);

                    var ok = TestWordChain(wordTest, shorterWords, ref currentResult);

                    if (ok)
                    {
                        currentResult = Math.Max(currentResult, currentLength);
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return false;
        }
    }
}