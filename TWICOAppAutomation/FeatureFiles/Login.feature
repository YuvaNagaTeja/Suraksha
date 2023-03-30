Feature: Login

A short summary of the feature

@Browser:Chrome
@Login
Scenario: Login to application
	Given Open the browser
	When  UserName and Password given
	Then User should login to application successfully
