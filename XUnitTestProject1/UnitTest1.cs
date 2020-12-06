using System;
using System.Linq;
using TestConsoleApp;
using Xunit;
using Shouldly;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var words = new string[]
                {"a", "and", "an", "bear"};

            var result = WordChain.LongestChain(words.ToList());

            result.ShouldBe(3);
        }

        [Fact]
        public void Test2()
        {
            var words = new string[]
                {"a", "b", "ba", "bca" , "bda" , "bdca"};

            var result = WordChain.LongestChain(words.ToList());

            result.ShouldBe(4);
        }

        [Fact]
        public void Test3()
        {
            var words = new string[]
                {"a", "ba", "aba", "abac", "agacd"};

            var result = WordChain.LongestChain(words.ToList());

            result.ShouldBe(4);
        }

        [Fact]
        public void Test4()
        {
            var words = new string[]
                {"9", "a", "zxb", "ba" , "bca" , "bda" ,"bdca" , "zxbe" , "azxbe", "azxpbe"};

            var result = WordChain.LongestChain(words.ToList());

            result.ShouldBe(4);
        }
    }
}
