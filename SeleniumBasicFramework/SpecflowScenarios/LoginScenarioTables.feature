Feature: LoginScenariosTables
	As a user I would be able to successfully 
	login if I enter a valid username and password


@mytag
Scenario Outline: LoginScenario
	Given Im currently in the login page
	When I have entered a valid <username> and <password>
	Then I would be able to login successfully to the site
Examples: 
| username   | password |
| mngr176797 | jaseteb  |
