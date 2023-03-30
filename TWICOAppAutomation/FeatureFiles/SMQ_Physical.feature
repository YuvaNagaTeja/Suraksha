Feature: SMQ_Physical

A short summary of the feature

@durgaTestCase_2
Scenario: Verify FIG able to see success message after submitting all the SMQ forms over the Physical Upload Screen
	Given Login into Suraksha Portal
	When Clik on SMQ Dropdown 
	And click on SMQ Physical DashBoard
	Then Click on upload Data
	And Upload zip file
	Then click on import data button
	Then User should be able to see the success message as SMQ has been uploaded successfully


@durgaTestCase_6
Scenario: Verify FIG able to Navigate to Physical dashboard and see the All data and SMQ Pending  tabs on the Physical dashboard screen
	Given Login into Suraksha Portal
	When Clik on SMQ Dropdown 
	And click on SMQ Physical DashBoard 
	Then User should be able to see the All data and SMQ Pending tabs on the Physical upload screen with the count

@durgaTestCase_26
Scenario: Verify FIG able to Navigate to SMQ Digital Dashboard screen
	Given Login into Suraksha Portal
	When Clik on SMQ Dropdown 
	And Click on SMQ Digital DashBoard
	Then Verify User should be able to Navigate to Digital SMQ Dashboard screen successfully


@TC_(14)_Durga
Scenario: Verify borrower able to enter Height in Height field
    Given Login into Suraksha Portal
    Then Verify navigated to Dashboard page
    Then Click on Active Cases
    Then Select the Category and click on Search button
    Then Verify SMQ Link Status
    Then Click on searchresult
    Then Navigate to TestURL, give Date of Birth
    And Click on Authenticate
    Then User should be able to click on start button and navigate to SMQ submission page
    And User should click on Continue on Medical Details button
    Then User should be able to enter Height in Feet and Inches

@durgaTestCase_22
    Scenario: Verify Borrower able to see Life Assured details and Nominee Assured details and click on Continue to Medical details button
    Given Login into Suraksha Portal
    Then Verify navigated to Dashboard page
    Then Click on Active Cases
    Then Select the Category and click on Search button
    Then Verify SMQ Link Status
    Then Click on searchresult
    Then Navigate to TestURL, give Date of Birth
    And Click on Authenticate
    Then User should be able to click on start button and navigate to SMQ submission page
    Then Verify User should be able to see Life Assured details and Nominee assured details and click on Continue to Medical Details button

@durgaTestCase_18
Scenario: Verify borrower able to select Primary Borrower or Co-borrower from dropdown from first page of Review
    Given Login into Suraksha Portal
    Then Verify navigated to Dashboard page
    Then Click on Active Cases
    Then Select the Category and click on Search button
    Then Verify SMQ Link Status
    Then Click on searchresult
    Then Navigate to TestURL, give Date of Birth
    And Click on Authenticate
    Then User should be able to click on start button and navigate to SMQ submission page
    And User should click on Continue on Medical Details button
    Then User should be able to select Primary Borrower or Co-borrower from the Primary Borrower or Co-borrower dropdown in the first review page