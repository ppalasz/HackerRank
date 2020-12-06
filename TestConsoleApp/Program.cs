using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace TestConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
                {"9", "a", "zxb", "ba" , "bca" , "bda" ,"bdca" , "zxbe" , "azxbe", "azxpbe"};

            var result = WordChain.LongestChain(words.ToList());

            Console.WriteLine($"longest chain = {result}");

            Console.ReadLine();
        }


       
    }
}
