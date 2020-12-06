using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
                {"a", "ba", "aba", "abac", "agacd"};

            //var words = new string[]
            //    {"a", "b", "ba", "bca" , "bda" , "bdca"};


            //var words = new string[]
            //    {"9", "a", "zxb", "ba" , "bca" , "bda" ,"bdca" , "zxbe" , "azxbe", "azxpbe"};

            var result = Testing.LongestChain(words.ToList());

            Console.WriteLine($"result={result}");

            Console.ReadLine();
        }


        /*
          static string[] getMovieTitles(string substr)
        {
            var movies = new List<string>();
            var baseUrl = "https://jsonmock.hackerrank.com/api/movies/search/";

            var startPage = 1;
            var totalPages = int.MaxValue;
            var titles = new List<string>();
            var client = new WebClient();

            while (startPage <= totalPages)
            {
                var url = new Uri($"{baseUrl}?Title={substr}&page={startPage}");
                var json = client.DownloadString(url);

                var pageResponse = JsonConvert.DeserializeObject<ApiResponse>(json);

                totalPages = pageResponse.TotalPages;

                foreach (var movie in pageResponse.Data)
                {
                    movies.Add(movie.Title);
                }
                startPage++;
            }

            return movies.OrderBy(x=>x).ToArray();
        }


        public class ApiResponse
        {
            public string Page { get; set; }

            [JsonProperty("per_page")]
            public int PerPage { get; set; }

            public int Total { get; set; }

            [JsonProperty("total_pages")]
            public int TotalPages { get; set; }

            public IEnumerable<Movie> Data { get; set; }
        }


        public class Movie
        {
            public string Poster { get; set; }
            public string Title { get; set; }
            public string Type { get; set; }
            public int Year { get; set; }

            [JsonProperty("imdbID")]
            public string ImdbId { get; set; }
        }

         */
    }
}
