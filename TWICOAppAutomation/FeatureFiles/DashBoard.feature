Feature: DashBoard
Verifying a Dashboard functionality

@Teja
Scenario: Verify Group Ops user able to view "Total Active Cases" and "Ongoing Medical Cases" tabs in the Dashboard    
	Given Enter Suraksha Portal URL in the browser
    When Enter Emaild ID and Password
    Then Click on Sign In button
    Then User should land on the Dashboard page after successful login
    Then user should validate respective tabs display on Dashboard

@Teja
Scenario: Verify Group Ops User able to view the dropdown values for searchby option    
	Given Login into Suraksha Portal
    When Navigated to Dashboard page
    Then User should land on the Dashboard page after successful login
    Then User should click on the dropdown of Searchby option
    And verify the dropdown values

@durgaTC_SP_GOD_011
Scenario: Verify Group Ops user able to download the medical Cases into excel after clicking on Ongoing Medical Cases tab
    Given Enter Suraksha Portal URL in the browser
    When Enter Emaild ID and Password
    Then Click on Sign In button
    And Click on Ongoing Medical Cases
    Then Click on Export button
    And Verify excel sheet is downloaded
    Then Verify No of Medical Cases displayin in the dashboard should match with the number downloaded into excel

@durgaTC_SP_GOD_021
Scenario: Verify user able to Search the Customer ID using searchby option
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	And User should click on the Customer ID from the  dropdown of Searchby option
	Then User should provide the customer id in the search box
	And user should click on search
	Then Verify policy record with respect to the customer id should display on the resultant grid
	
@Nikhila @Nikhila_TC_SP_GOD_013 
Scenario: Verify Group Ops user able to view the respective fields in the Dashboard
  Given Enter Suraksha Portal URL in the browser
  When Enter Emaild ID and Password
  Then Click on Sign In button
  Then Group Ops user able to view the respective fields searchby (dropdown), searchbox, add filter, view and export to excel in the Dashboard 

@Nikhila @Nikhila_TC_SP_GOD_050 
Scenario: Verify loan no from the dashboard in the resultant grid is a link
  Given Enter Suraksha Portal URL in the browser
  When Enter Emaild ID and Password
  Then Click on Sign In button
  Then validate the Loan number in the resultant grid, Loan number should be a link

@Pavan
Scenario: Verify user able to land on the dashboard screen after login into Suraksha Portal
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	And Verify User should land on the dashboard Screen

@Pavan
Scenario: Verify Group Ops user able to export the data into excel
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	And Verify user should click on the Export to Excel option from the dashboard





@ActiveCases @Demo
Scenario: Verify Total Active cases from the dashboard
	Given Login into Suraksha Portal
	When Navigated to Dashboard page
	Then Click on Active Cases
	Then Click on Export button
	And Verify excel sheet is downloaded
	When User clicked on first record
	Then User should navigate to details page and get loan id
	And User should navigate to dashboard page again
	Then User should select a category as loan number and give loan id in search box and click on search
	Then Verify loan id details with result page
	And Click on result first record it should navigate to details page
	Then Verify user able to click on each tabs
	

@OngoingCases @Demo
Scenario: Verify Total Ongoing cases from the dashboard
	Given Login into Suraksha Portal
	When Navigated to Dashboard page
	Then Click on Ongoing Medical Cases
	Then Click on Export button
	And Verify excel sheet is downloaded
	When User clicked on first record
	Then User should navigate to details page and get loan id
	And User should navigate to dashboard page again
	Then User should select a category as loan number and give loan id in search box and click on search
	Then Verify loan id details with result page
	And Click on result first record it should navigate to details page
	Then Verify user able to click on each tabs
	
