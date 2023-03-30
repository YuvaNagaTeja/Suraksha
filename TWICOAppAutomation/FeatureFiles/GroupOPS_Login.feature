Feature: GroupOPS_Login

A short summary of the feature
@Nikhila @TC04_Nikhila(GroupOps_Login) 
  Scenario: Verify User able to click on sign-in button.
  Given Enter Suraksha Portal URL in the browser
  When Enter Emaild ID and Password
  Then Click on Sign In button

@Pavan
Scenario: Verify if the user is able to launch the Suraksha application and land on login page
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	And Verify User should land on the dashboard Screen

@Pavan
Scenario: Verify User able to login as Group Ops
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	And User should be able to login to application as Group Ops

@TC_2 @teja
Scenario: Verify User able to enter the valid EmailId.
	Then Launch the browser and enter the Suraksha Portal url.
	And Enter Email ID.
	Then Observe the screen
