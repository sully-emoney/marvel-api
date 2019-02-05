using System;
using System.Linq;

namespace Marvel.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DisplayComic();
            Pause();
            DisplayCharacters();
            Pause();
        }

        private static void DisplayComic()
        {
            Console.WriteLine("COMICS");
            var title = "Daredevil: Born Again";
            var comic = Comic.GetComic(title);

            Console.WriteLine($"A comic starting with \"{title}\" as the title.");
            Console.WriteLine($" - {comic.Title}");
            Console.WriteLine($" - It went on sale {comic.SaleDate.ToString("dd/MM/yyyy")}");
        }

        private static void DisplayCharacters()
        {
            Console.WriteLine("CHARACTERS");
            var name = "Spider-Woman";

            var characters = Character.FindByName(name);

            Console.WriteLine($"Found {characters.Count} characters starting with \"{name}\"");

            foreach (var character in characters)
            {
                Console.WriteLine(character.Name);
            }

            foreach (var character in characters)
            {
                Console.WriteLine(Environment.NewLine);
                DisplayComicsForCharacter(character);
            }
        }

        private static void DisplayComicsForCharacter(Character character)
        {
            Pause();

            var comics = Comic.GetComics(character);

            if (!comics.Any())
            {
                Console.WriteLine($"No comics with \"{character.Name}\" as a character.");
                return;
            }

            Console.WriteLine($"A comic with \"{character.Name}\" as a character:");
            foreach (var comic in comics)
            {
                Console.WriteLine($" - {comic.Title}");
            }
        }

        private static void Pause()
        {
            Console.WriteLine(Environment.NewLine);
            Console.ReadLine();
        }
    }
}
