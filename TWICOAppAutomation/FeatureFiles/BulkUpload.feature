Feature: BulkUpload
A short summary of the feature


@TC04_Nikhila(BulkUpload)
Scenario: Verify user able to Navigate to View Bulk Upload Screen
    Given Enter Suraksha Portal URL in the browser
    When Enter Emaild ID and Password
    Then Click on Sign In button
    Then Verify navigated to Dashboard page
    Then Click Create application on the left side of the screen
    And Click on View Bulk Upload in Create application
    Then Verify View Bulk Upload page loaded successfully

@Teja
Scenario: Verify Financial Institution field is auto populated and non-editable     
Given Login into Suraksha Portal as ExternalUser
    Then Click Create application on the left side of the screen
    And Click on Bulk Upload in Create application
    Then Observe the FI field

@durgaID3
Scenario:Verify FIG able to import the Excel file from the local drive in Upload file field
    Given Login into Suraksha Portal
    Then Verify navigated to Dashboard page
    Then Click Create application on the left side of the screen
    And Click on Bulk Upload in Create application
    Then User should be able to navigate to Bulk upload screen successfully
    Then User should be able to see FI field is auto populated and disabled
    Then User should select the file and upload

@Teja
Scenario: Verify FIG able to download the records when click on Failed number hyperlink
    Given Enter Suraksha Portal URL in the browser
    When Enter Emaild ID and Password
    Then Click on Sign In button
    Then Click Create application on the left side of the screen
    And Click on View Bulk Upload in Create application
    Then Click on Failed number Hyperlink and download"


@Pavan
Scenario: Verify FIG able to Navigate to Bulk upload screen
Given Enter Suraksha Portal URL in the browser
When Enter Emaild ID and Password
Then Click on Sign In button
Then Click Create application on the left side of the screen
Then Click on Bulk Upload in Create application
Then User should be able to navigate to Bulk upload screen successfully

@Pavan
Scenario: Verify FIG able to download the records when click on Success number hyperlink
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	And Click on View Bulk Upload in Create application
	Then Verify View Bulk Upload page loaded successfully
	Then User should be able to download the success number of records  






@TC1_BulkUpload @Demo
Scenario: Verify user able to Navigate to Bulk upload screen
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	And Click on Bulk Upload in Create application
	Then User should be able to navigate to Bulk upload screen successfully
	Then User should be able to see FI field is auto populated and disabled
	Then User should select the file and upload
	Then Verify the successfull messages and click okay button

@TC2_BulkUpload @Demo
Scenario: Verify user able to navigate to the View Bulk upload screen
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	And Click on View Bulk Upload in Create application
	Then Verify View Bulk Upload page loaded successfully
	Then Give necessary data and click on Load Data button

@TC3_FailedErrors @Demo
Scenario: Verify Errors file
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	And Click on View Bulk Upload in Create application
	Then Verify View Bulk Upload page loaded successfully
	Then Give necessary data and click on failed cases link