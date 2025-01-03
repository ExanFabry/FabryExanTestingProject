Feature: returnerrorifgenreisnotinenum

A short summary of the feature
If the genre is not in the enum it returns an error.

@returnerrorifgenreisnotinenum
Scenario: Return error
	Given the application is running for failed test
	When a movie genre (.*) is selected and fails
	Then an error is given
