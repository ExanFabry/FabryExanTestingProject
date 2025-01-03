using FabryExanProject.Models;
using FabryExanProject.Services;
using Moq;

namespace TestProject
{
    public class Tests
    {
        //Beslissingsmodule

        //Als er een juist genre gekozen wordt dan wordt er gecontroleerd of het genre in de enum staat.
        [Test]
        public void CheckIfGenreExists()
        {
            if (FabryExanProject.Services.BeslissingModule.ChooseGenre("action") == true)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //Als er een fout genre gekozen wordt dan wordt er gecontroleerd of false word meegestuurt.
        [Test]
        public void CheckIfGenreDoesNotExist()
        {
            // Arrange
            string invalidGenre = "fout genre";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() =>
                FabryExanProject.Services.BeslissingModule.ChooseGenre(invalidGenre)
            );

            StringAssert.Contains($"Ongeldige optie meegegeven", ex.Message);
        }

        //Integratietesten
        [Test]
        public void GetFilmWithSpecificGenre()
        {
            var filmApi = new Mock<IHandelingen>();
            filmApi.Setup(x => x.ReturnFilmWithGenre("action")).Returns(Task.FromResult(new Films(3, "John Wick", Genre.Action)));
            var filmService = filmApi.Object;
            var result = filmService.ReturnFilmWithGenre("action").Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Id);
            Assert.AreEqual("John Wick", result.Title);
            Assert.AreEqual(Genre.Action, result.Genre);
        }
        [Test]
        public void AllFilmsShouldReturnListOfFilms()
        {
            var handelingen = new Handelingen();
            List<Films> result = handelingen.AllFilms();
            Assert.NotNull(result);
            Assert.True(result is List<Films>);
            Assert.True(result.Count > 0);
        }
        [Test]
        public void ValidateGenreWithValidGenreReturnsTrue()
        {
            string validGenre = "Action";
            bool result = FabryExanProject.Services.BeslissingModule.ChooseGenre(validGenre);
            Assert.True(result);
        }
        [Test]
        public void ValidateGenreWithWrongGenreReturnsFalse()
        {
            string invalidGenre = "Fout genre";
            var exception = Assert.Throws<ArgumentException>(() => FabryExanProject.Services.BeslissingModule.ChooseGenre(invalidGenre));
            Assert.False(exception.Message.Contains($"Genre '{invalidGenre}' bestaat niet in de beschikbare genres."));
        }
    }
}