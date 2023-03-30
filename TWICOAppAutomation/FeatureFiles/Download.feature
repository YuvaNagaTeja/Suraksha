Feature: Download

A short summary of the feature

@durgaID7
Scenario: Verify FIG able to navigate to Download screen
    Given Login into Suraksha Portal
    When Click Create application on the left side of the screen
    And Click on Download in Create Application
    Then Verify User should be able to navigate to Download screen

@Pavan
@DataSource:DownloadSearch.xlsx
Scenario: Verify FIG able to download in ZIP format for the searched details
    Given Login into Suraksha Portal
    When Click Create application on the left side of the screen
    And Click on Download in Create Application
	Then Enter the search details like <Financial Institution>, <Region>, <Branch>, <Policy Number>, <From Date>, <To Date>, <Document Type>, <Loan ID>
	And click on search button
	And Download the file
	Then User should be able to download the file of searched results in ZIP format

@Nikhila_DownloadScreen
Scenario: User should be able to see the results for provided search details 
  Given Enter Suraksha Portal URL in the browser
  When Enter Emaild ID and Password
  Then Click on Sign In button
  Then Click Create application on the left side of the screen
  Then user should click on download option in the left menu
  And User should enter FI,region,Branch,policynumber,from-To date,Document type and click on search button
  And validate headers of Financial Institute Data
  Then Click on download Button
