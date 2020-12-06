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


            var result = Testing.LongestChain(words.ToList());

        }

        public void Test2()
        {
            var words = new string[]
                {"a", "b", "ba", "bca" , "bda" , "bdca"};


            var result = Testing.LongestChain(words.ToList());

            result.ShouldBe(4);
        }
    }
}
