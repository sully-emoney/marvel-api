using System;
using System.Linq;
using NUnit.Framework;

namespace Marvel.Tests
{
    [TestFixture]
    public class ComicTest
    {
        [Test]
        public void GivenTitle_WhenGetComic_ReturnComic()
        {
            // arrange
            var title = "Spider-Ham";

            // act 
            var subject = Comic.GetComic(title);

            // assert
            Assert.That(subject.Title, Is.EqualTo("Spider-Ham 25th Anniversary Special (2010) #1"));
            Assert.That(subject.SaleDate, Is.EqualTo(DateTime.Parse("2010-06-30")));
        }

        [Test]
        public void GivenCharacter_WhenGetComics_ReturnComics()
        {
            // arrange
            var character = new Character {Id = 1009378};

            // act 
            var subject = Comic.GetComics(character);

            // assert
            Assert.That(subject.Count(), Is.EqualTo(5));
            Assert.That(subject[0].Title, Is.EqualTo("Jessica Jones - Marvel Digital Original: Purple Daughter (2019) #1"));
            Assert.That(subject[1].Title, Is.EqualTo("Jessica Jones: Blind Spot (Trade Paperback)"));
            Assert.That(subject[2].Title, Is.EqualTo("Luke Cage - Marvel Digital Original (2018) #3"));
            Assert.That(subject[3].Title, Is.EqualTo("Jessica Jones - Marvel Digital Original (2018) #3"));
            Assert.That(subject[4].Title, Is.EqualTo("Luke Cage - Marvel Digital Original (2018) #2"));
        }
    }
}
