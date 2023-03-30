Feature: FIGUser

A short summary of the feature

@FigUserTestCase1
Scenario Outline: Verify FIG User able to navigate to premium calculator using left navigation menu
	Given User should login into Suraksha using <UserName> and <Password>	
	Then User should click on Create application
	And User should click on Premium Calculator
	Examples: 
		| UserName                         | Password  |
		| Venkatesh.yada@valuemomentum.com | Venky@123 |

@FigUserTestCase2
Scenario: Verify FIG User able to calculate premium without updating mandatory values in the premium calculator page
	Given User should login into Suraksha using user name and password
		| UserName                         | Password  |
		| Venkatesh.yada@valuemomentum.com | Venky@123 |
	Then User should click on Create application
	And User should click on Premium Calculator
	Then User should click on Calculate Premium

@FigUserTestCase3
Scenario: Verify FIG User able to enter values for the following fields
	Given User should login into Suraksha using user name and password
		| UserName                         | Password  |
		| Venkatesh.yada@valuemomentum.com | Venky@123 |
	Then User should click on Create application
	And User should click on Premium Calculator
	Then User should click on Calculate Premium
	Then User should enter/select the following fields

@FigUserTestCase4
@DataSource:UserTestData.xlsx
Scenario: Verify FIG User able to view values like after clicking on Region dropdown
	Given User should login into Suraksha using <UserName> and <Password> 
	Then User should click on Create application
	And User should click on Premium Calculator
	Then Verify FIG User able to view values after clicking on Region	 


@FigUserTestCase5
Scenario: Verify FIG User able to view the two dropdown (years and Months) for Tenure field.
	Given User should login into Suraksha using user name and password
		| UserName                         | Password  |
		| Venkatesh.yada@valuemomentum.com | Venky@123 |
	Then User should click on Create application
	And User should click on Premium Calculator
	Then Verify Years Months dropdown should display for Tenure in premium calculator screen
	
@FigUserTestCase6
Scenario: Verify FIG User able to view Date of Birth Secondary Insured is displayed after selecting Policy Type - Joint Policy/Co-borrower
	Given User should login into Suraksha using user name and password
		| UserName                         | Password  |
		| Venkatesh.yada@valuemomentum.com | Venky@123 |
	Then User should click on Create application
	And User should click on Premium Calculator
	And User should select Policy Type - Joint Life/Co-Borrower from the dropdown 
	Then Verify Date of birth of Secondary Insured field should get added on the screen




