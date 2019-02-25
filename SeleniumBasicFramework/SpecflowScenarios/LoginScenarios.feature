Feature: LoginScenarios
	As a user I would be able to successfully 
	login if I enter a valid username and password

@mytag
Scenario: LoginScenario
	Given Im in the login page 
	When I have entered valid username and password
	Then I would be able to login successfully
