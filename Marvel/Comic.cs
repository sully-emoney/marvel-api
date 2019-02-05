using System;
using System.Collections.Generic;
using Marvel.Api;
using Marvel.Api.Filters;
using Marvel.Api.Results;

namespace Marvel
{
    public class Comic
    {
        public string Title { get; set; }
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Limited to the 1 comic ordered by Name Ascending
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static Comic GetComic(string title)
        {
            var creds = new Credentials();
            var client = new MarvelRestClient(creds.PublicKey, creds.PrivateKey);

            var filter = new ComicRequestFilter();
            filter.OrderBy(OrderResult.NameAscending);
            filter.Limit = 1;
            filter.TitleStartsWith = title;

            var comicResponse = client.FindComics(filter);

            return ResultsToList(comicResponse)[0];
        }


        /// <summary>
        /// Limited to the top 5 comics ordered by Name Ascending
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static List<Comic> GetComics(Character character)
        {
            var creds = new Credentials();
            var client = new MarvelRestClient(creds.PublicKey, creds.PrivateKey);

            var filter = new ComicRequestFilter();
            filter.OrderBy(OrderResult.NameAscending);
            filter.Limit = 5;

            var comicResponse = client.FindCharacterComics(character.Id.ToString(), filter);

            return ResultsToList(comicResponse);
        }

        private static List<Comic> ResultsToList(ComicResult response)
        {
            var comics = new List<Comic>();

            foreach (var r in response.Data.Results)
            {
                var comic = new Comic()
                {
                    Title = r.Title,
                    SaleDate = DateTime.Parse(r.Dates.Find(d => d.Type == "onsaleDate").Date)
                };
                comics.Add(comic);
            }

            return comics;
        }

    }
}
