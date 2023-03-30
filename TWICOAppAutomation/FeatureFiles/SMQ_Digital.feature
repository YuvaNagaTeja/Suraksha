Feature: SMQ_Digital

A short summary of the feature

@Nikhila @ID11_Nikhila(SMQ)
Scenario: Verify borrower able to accept the declaration checkbox and click on ok button
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button

@Nikhila @ID15_Nikhila(SMQ)
Scenario: Verify borrower able to enter Annual income in annual income field
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button

@Nikhila @ID19_Nikhila(SMQ)
Scenario: Verify borrower able to select Type of Employement from dropdown from first page of Review
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button

@Nikhila @ID23_Nikhila(SMQ)
Scenario: Verify if Borrower is able to navigate to authentication page and enter DOB
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate


@ID7_Nikhila(SMQ) @Nikhila
Scenario: Verify borrower able to see the submitted success message once the verification via Mobile OTP is done
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button
	Then Navigate to Submit screen
	Then Click on Mobile OTP and Enter OTP
	Then Click on validate OTP button and submit the records

@TC_4(13)
Scenario: Verify if Borrower is able to click on start button and navigate to SMQ submission page
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	Then User should be able to click on start button and navigate to SMQ submission page

@TC_6_(21)
Scenario: Verify borrower able to select Nationality from dropdown from first page of Review
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
	Then User should be able to select Nationality from the Nationality dropdown in the first review page

@TC_5(17)
Scenario: Verify Borrower able to see enter Pan Card number in the Pan number field
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
	Then User should able to enter Pan card number as Alpha numeric value with maximum value 10 character (AAAAA5555A)

	
@Pavan
Scenario: Verify borrower able to select Total No.of borrower’s from dropdown from first page of Review
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then User should be able to select Total No.of borrower’s from the Total No.of borrower’s dropdown in the first review page
	And Click on Continue to SMQ button
	
@Pavan
Scenario: Verify borrower able to enter Weight in kgs in Weight in kgs field
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then User should be able to enter two digits and three digits numbers in Weight in kgs field
	And Click on Continue to SMQ button
	
@Pavan
Scenario: Verify if Borrower is able to navigate to authentication page and enter OTP
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button
	Then Navigate to Submit screen
	Then Click on Mobile OTP and Enter OTP
	Then Click on validate OTP button and submit the records
	Then Validate the Underwriting decision Status
@Pavan
Scenario: Verify borrower able to regenerate the OTP for the Verification via Mobile OTP
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button
	Then Navigate to Submit screen
	Then Click on Mobile OTP and Enter OTP
	Then Click on validate OTP button and submit the records
	Then Validate the Underwriting decision Status
	

@Pavan
Scenario: Verify borrower able to click on continue to summary button and redirect to Final submit page
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button
	Then Navigate to Submit screen
	Then Click on Mobile OTP and Enter OTP
	Then Click on validate OTP button and submit the records
	Then Validate the Underwriting decision Status



@SMQ_TestCase1 @Demo
Scenario: Verify SMQ E2E Flow
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button
	And User should click on Continue on Medical Details button
	Then Select Mandatory fields and click on Continue to SMQ button




@SMQ_TestCase2 @Demo
Scenario: Verify User able to see Underwriting decision as "Refer to Underwriter" once the SMQ is submitted successfully
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button
	Then Navigate to Submit screen
	Then Click on Mobile OTP and Enter OTP
	Then Click on validate OTP button and submit the records
	Then Validate the Underwriting decision Status


	
@SMQ_TestCase3
Scenario: Verify User able to submit 2 or more co-borrowers
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button
	Then Navigate to Submit screen
	Then Click on Mobile OTP and Enter OTP
	Then Click on validate OTP button and submit the records
	Then Validate the Underwriting decision Status

@ID27_Nikhila(SMQ)
Scenario: Verify FIG able to Navigate to SMQ Dashboard screen
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on SMQ Physical Dashborad from Application on the left menu of Screen
	Then Click on SMQ Digital Dashborad from Application on the left menu of Screen


@teja3(9)
Scenario: Verify borrower able to see the submitted success message once the verification via Adhaar is done
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then Validate the screen and click on continue button
	Then Navigate to first page review
	Then Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button
	Then Answer all questions and click on continue button
	Then Navigate to Submit screen
	Then Click on Mobile OTP and Enter OTP
	Then Click on validate OTP button and submit the records
	And User should be able to see success message as - SMQ details are successfully submitted

@TC_4(13)teja
Scenario: Verify borrower able to click on Continue to Medical details button and navigate to Fill page
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click on Active Cases
	Then Select the Category and click on Search button
	Then Verify Underwriting Decision status
	Then Verify SMQ Link Status
	Then Click on searchresult
	Then Navigate to TestURL, give Date of Birth
	And Click on Authenticate
	And Click on Start button and redirect to first page
	Then User should be able to click on Continue to SMQ button and navigate to Fill page
