using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using FabryExanProject.Services;
using FabryExanProject.Models;

namespace SpecFlowTesting.StepDefinitions
{
    [Binding]
    public sealed class ReturnErrorIfGenreIsNotInEnum
    {
        private bool appRunning;
        private string selectedGenre;

        [Given("the application is running for failed test")]
        public void GivenTheApplicationIsRunning()
        {
            appRunning = true;
            appRunning.Should().BeTrue("The application failed to start.");
        }

        [When("a movie genre (.*) is selected and fails")]
        public void WhenTheUserSelectsGenreAndConfirms(string genre)
        {
            selectedGenre = genre;
        }

        [Then("an error is given")]
        public void ThenAnErrorIsGiven()
        {
            Action act = () => FabryExanProject.Services.BeslissingModule.ChooseGenre(selectedGenre);
            act.Should()
               .Throw<ArgumentException>()
               .WithMessage($"Ongeldige optie meegegeven: '{selectedGenre}'", "An invalid genre should trigger an ArgumentException.");
        }
    }
}
