Feature: Login
	As a user
	I want to login
	So that I can access the application


Scenario Outline: Login with valid credentials
	Given I am on the login page
	When I enter Username <username>
	When I enter Password <password>
	When I click on login button
	Then I should be logged in 
Examples: 
| username |password |
| admin    | admin   |
| admin1   | admin1  |
