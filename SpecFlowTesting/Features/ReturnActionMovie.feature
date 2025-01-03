Feature: ReturnActionMovie

A short summary of the feature
Checking if the api return an action movie

@returnactionmovie
Scenario: Return action movie
	Given the application is running
	When a movie genre 'Action' is selected and confirmed
	Then a random movie (.*) from that genre is chosen