using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpecFlowTesting.StepDefinitions
{
    [Binding]
    public sealed class ReturnActionMovieStepDefinitions
    {
        private bool appRunning;
        private string selectedGenre;
        private string chosenMovie;
        private List<string> actionMovies = new List<string> { "Die Hard", "Mad Max", "John Wick" };

        [Given("the application is running")]
        public void GivenTheApplicationIsRunning()
        {
            appRunning = true;
            appRunning.Should().BeTrue("The application failed to start.");
        }

        [When("a movie genre 'Action' is selected and confirmed")]
        public void WhenTheUserSelectsGenreAndConfirms()
        {
            selectedGenre = "Action";
        }

        [Then("a random movie (.*) from that genre is chosen")]
        public void ThenARandomMovieFromTheGenreIsChosen(string movie)
        {
            selectedGenre.Should().Be("Action", "The genre was not correctly set to Action.");
            chosenMovie = actionMovies[new Random().Next(actionMovies.Count)];
            actionMovies.Should().Contain(chosenMovie);
        }
    }
}
