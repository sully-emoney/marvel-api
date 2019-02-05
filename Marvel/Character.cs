using System.Collections.Generic;
using Marvel.Api;
using Marvel.Api.Filters;
using Marvel.Api.Results;

namespace Marvel
{
    public class Character
    {
        public string Name { get; set; }
        internal int Id { get; set; }

        public static List<Character> FindByName(string name)
        {
            var creds = new Credentials();
            var client = new MarvelRestClient(creds.PublicKey, creds.PrivateKey);

            var filter = new CharacterRequestFilter();
            filter.NameStartsWith = name;

            var response = client.FindCharacters(filter);

            return ResultsToList(response);
        }

        private static List<Character> ResultsToList(CharacterResult response)
        {
            var characters = new List<Character>();

            foreach (var r in response.Data.Results)
            {
                var character = new Character
                {
                    Name = r.Name,
                    Id = r.Id
                };
                characters.Add(character);
            }

            return characters;
        }
    }
}
