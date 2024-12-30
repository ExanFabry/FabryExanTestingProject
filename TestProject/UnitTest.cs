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
    }
}