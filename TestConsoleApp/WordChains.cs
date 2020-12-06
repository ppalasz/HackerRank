using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    public static class WordChain
    {
        public static int LongestChain(List<string> words)
        {
            var result = 0;

            var testWords = words
                .OrderBy(x => x.Length)
                .ToList();
            
            var wordsToWork = testWords?
                .Where(x => x.Length > 1)
                .OrderBy(x => x.Length)
                .ToList();

            foreach (var word in wordsToWork)
            {
                if (word.Length <= result)
                {
                    continue;
                }

                var testResult = TestWordChain(word, testWords, ref result);
            }

            return result;
        }

        private static bool TestWordChain(string word, List<string> testWords,  ref int currentResult)
        {
            var currentLength = word.Length;
            
            var shorterWords = testWords?
                .Where(x => x.Length < currentLength)
                .ToList();
            
            for (var i = 0; i < word.Length; i++)
            {
                var wordTest = $"{word.Substring(0, i)}{word.Substring(i + 1)}";

                if (shorterWords.Contains(wordTest))
                {
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