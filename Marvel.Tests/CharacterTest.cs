using System.Linq;
using NUnit.Framework;

namespace Marvel.Tests
{
    [TestFixture]
    public class CharacterTest
    {
        [Test]
        public void GivenName_WhenGetCharacters_ReturnCharactersStaringWithName()
        {
            // arrange
            var name = "Spider-Man";

            // act 
            var subject = Character.FindByName(name);

            // assert
            Assert.That(subject.Count(), Is.EqualTo(13));
            Assert.That(subject[0].Name, Is.EqualTo("Spider-Man"));
            Assert.That(subject[1].Name, Is.EqualTo("Spider-Man (1602)"));
            Assert.That(subject[2].Name, Is.EqualTo("Spider-Man (2099)"));
            Assert.That(subject[3].Name, Is.EqualTo("Spider-Man (Ai Apaec)"));
            Assert.That(subject[4].Name, Is.EqualTo("Spider-Man (Ben Reilly)"));
            Assert.That(subject[5].Name, Is.EqualTo("Spider-Man (House of M)"));
            Assert.That(subject[6].Name, Is.EqualTo("Spider-Man (LEGO Marvel Super Heroes)"));
            Assert.That(subject[7].Name, Is.EqualTo("Spider-Man (Marvel Zombies)"));
            Assert.That(subject[8].Name, Is.EqualTo("Spider-Man (Marvel: Avengers Alliance)"));
            Assert.That(subject[9].Name, Is.EqualTo("Spider-Man (Miles Morales)"));
            Assert.That(subject[10].Name, Is.EqualTo("Spider-Man (Noir)"));
            Assert.That(subject[11].Name, Is.EqualTo("Spider-Man (Takuya Yamashiro)"));
            Assert.That(subject[12].Name, Is.EqualTo("Spider-Man (Ultimate)"));
        }
    }
}
