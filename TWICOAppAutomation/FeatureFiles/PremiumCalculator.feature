Feature: PremiumCalculator

A short summary of the feature

@ID_3_Nikhila_(PremiumCalculator) @Nikhila
@DataSource:ID3_NomieeAge18.xlsx @DataSet:SampleReport
Scenario Outline: Verify User able to submit the application when nominee is = 18 years of age
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button

@ID_7_Nikhila_(PremiumCalculator) @Nikhila
@DataSource:ID7.xlsx @DataSet:SampleReport
Scenario Outline: Verify FIG user able to submit the application using Policy - CD000247 and tenure 2 month
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button


@ID_11_Nikhila(PremiumCalculator) @Nikhila
@DataSource:ID11.xlsx @DataSet:SampleReport
Scenario Outline: Verify User able to calculate premium after updating all the required fields along with policy type - single life and mode - single premium in Premium calculator screen
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page

@ID_15_Nikhila(PremiumCalculator) @Nikhila
Scenario Outline: Verify User able to calculate premium without updating mandatory values in the premium calculator page
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	And click on calculate premium button
	Then Validate the error messages in the page


@teja2
@DataSource:PremiumCalculatorDataTeja1.xlsx @DataSet:SampleReport
Scenario: Verify FIG User able to submit the application for Policy Type - Single Life
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button

@durgaTestCase2
@DataSource:PremiumCalculatorDataNomineeBelow18.xlsx @DataSet:SampleReport
Scenario: Verify FIG User able to submit the application for single/joint life by adding appointee details when nominee is below 18 years of age
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button

@durgaTestCase14
Scenario: Verify FIG User able to navigate to premium calculator using left navigation menu
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page

@Pavan
@DataSource:PremiumCalculatorDataJointPolicy.xlsx @DataSet:SampleReport
Scenario Outline: Verify FIG User able to view Date of Birth Secondary Insured is displayed after selecting Policy Type - Joint Policy/Co-borrower
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	 

@TC1_PremiumCalculator @Pavan
@DataSource:PremiumCalculatorData4Nominees.xlsx @DataSet:SampleReport
Scenario Outline: PremiumCalculatorData4Nominees
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter first Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter Second Nominee <NOMINEE #2:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #2: Nominee's First Name>, <NOMINEE #2: Nominee's Sur Name>, <NOMINEE #2: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #2: Nominee's Gender>, <NOMINEE #2: Nominee's Relationship with Borrower>, <NOMINEE #2: %share if multiple Nominees>, <NOMINEE #2: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter Third Nominee <NOMINEE #3:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #3: Nominee's First Name>, <NOMINEE #3: Nominee's Sur Name>, <NOMINEE #3: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #3: Nominee's Gender>, <NOMINEE #3: Nominee's Relationship with Borrower>, <NOMINEE #3: %share if multiple Nominees>, <NOMINEE #3: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter fourth Nominee <NOMINEE #4:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #4: Nominee's First Name>, <NOMINEE #4: Nominee's Sur Name>, <NOMINEE #4: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #4: Nominee's Gender>, <NOMINEE #4: Nominee's Relationship with Borrower>, <NOMINEE #4: %share if multiple Nominees>, <NOMINEE #4: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button

	
@Teja
@DataSource:PremiumCalculatorData4Nominees_20laksh.xlsx @DataSet:SampleReport
Scenario Outline: Verify FIG User able to submit the application when cover amount is > 20Lakhs and underwriting status should be updated as SMQ
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter first Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter Second Nominee <NOMINEE #2:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #2: Nominee's First Name>, <NOMINEE #2: Nominee's Sur Name>, <NOMINEE #2: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #2: Nominee's Gender>, <NOMINEE #2: Nominee's Relationship with Borrower>, <NOMINEE #2: %share if multiple Nominees>, <NOMINEE #2: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter Third Nominee <NOMINEE #3:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #3: Nominee's First Name>, <NOMINEE #3: Nominee's Sur Name>, <NOMINEE #3: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #3: Nominee's Gender>, <NOMINEE #3: Nominee's Relationship with Borrower>, <NOMINEE #3: %share if multiple Nominees>, <NOMINEE #3: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter fourth Nominee <NOMINEE #4:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #4: Nominee's First Name>, <NOMINEE #4: Nominee's Sur Name>, <NOMINEE #4: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #4: Nominee's Gender>, <NOMINEE #4: Nominee's Relationship with Borrower>, <NOMINEE #4: %share if multiple Nominees>, <NOMINEE #4: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button
	Then User should able to view the application details in dashboard with Underwriting status - SMQ





@TC1_PremiumCalculator @Pavan
@DataSource:PremiumCalculatorData3Nominees.xlsx @DataSet:SampleReport
Scenario Outline: 3PremiumCalculatorData4Nominees
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter first Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter Second Nominee <NOMINEE #2:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #2: Nominee's First Name>, <NOMINEE #2: Nominee's Sur Name>, <NOMINEE #2: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #2: Nominee's Gender>, <NOMINEE #2: Nominee's Relationship with Borrower>, <NOMINEE #2: %share if multiple Nominees>, <NOMINEE #2: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	Then User should enter Third Nominee <NOMINEE #3:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #3: Nominee's First Name>, <NOMINEE #3: Nominee's Sur Name>, <NOMINEE #3: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #3: Nominee's Gender>, <NOMINEE #3: Nominee's Relationship with Borrower>, <NOMINEE #3: %share if multiple Nominees>, <NOMINEE #3: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button




@TC1_PremiumCalculator @Pavan
@DataSource:CoborrowerNominee_Transgender.xlsx @DataSet:SampleReport
Scenario Outline: Transgender Verfiy FIG User able to submit the application for policy type : Co-borrower for TransGender as borrower and nominee
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button

@TC1_PremiumCalculator @Demo
@DataSource:PremiumCalculatorData.xlsx @DataSet:SampleReport
Scenario Outline: Verify Premium Calculator Flow
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button


@ID_22_Nikhila_(PremiumCalculator)
@DataSource:ID11.xlsx @DataSet:SampleReport
Scenario Outline: Verify FIG User able to view the below fields in Borrower Address details page - Address line1, Address line 2, Address line3, Sate, Pin Code
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	Then Validate Borrower's Address page elements

@ID_19_Nikhila(PremiumCalculator)
@DataSource:ID11.xlsx @DataSet:SampleReport
Scenario Outline: Verify User able to view the fields in Borrower Address details page - Address line1, Address line 2, Address line3, State, Pin Code
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then validate premium output page elements

@teja3(9)
@DataSource:PremiumCalculatorDataTeja2.xlsx @DataSet:SampleReport
Scenario: Verify FIG user able to submit the application after clicking on "Edit" option in premium calculator page for single life policy
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then fill all the details as Single life
	Then User should click on Create Insurance Application button on Premium Output page
	And User shoud click on Edit after premium got successfully calculated
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>,  and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, , <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button


@teja4(13)
Scenario: Verify FIG User able to enter values for the following fields in premium calculator screen like Region, Financial Institution, Branch, Policy No - policy name,Policy Type, Mode, Borrower State, Date of Birth of Insured customer, Date of commencement of loan/cover, Age (in years) at commencement, Gender, Total Tenure (months/years), Cover Amount(Sanctioned Loan Amount), Is Premium Funded
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should able to enter/select the values successfully in firstPage

@teja(17)
@DataSource:PremiumCalculatorDataTeja2.xlsx @DataSet:SampleReport
Scenario: Verify FIG User able to calculate premium by providing DOB of Insured customer above 18 years and below 60 from the current date.
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	And Premium should get calculated sucessfully
	Then User should click on Create Insurance Application button on Premium Output page

 
@teja20
@DataSource:PremiumCalculatorDataTeja2.xlsx @DataSet:SampleReport
Scenario: Verify FIG user able to view the fields in editable after clicking on "Premium Calculator Output" page after successful premium calculation.
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	And Premium should get calculated sucessfully
	Then User should click on Create Insurance Application button on Premium Output page
	Then DOGH Submitted and Reference/UTR No should be in editable in premium calculator ouput page.

@teja(23)
@DataSource:PremiumCalculatorDataTeja2.xlsx @DataSet:SampleReport
Scenario: Verify FIG User able to enter mandatory details for Borrower's Address(line 1, line 2, line 3, State/UT, Country, pincode, mobile no and email id)after clicking on Borrower's address tab
	Given Enter Suraksha Portal URL in the browser
	When Enter Emaild ID and Password
	Then Click on Sign In button
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	Then User should able to add the data for all the fields in Borrower Address details tab.


@durgaTestCase6
@DataSource:PremiumCalculatorDataGH000373.xlsx @DataSet:SampleReport
Scenario: Verify FIG user able to submit the application using Policy GH000373 or GH000044 and tenure 12 months
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button

@durgaTestCase10
@DataSource:PremiumCalculatorDataNominee100percentshare.xlsx @DataSet:SampleReport
Scenario: Verify FIG User able to submit the application for single life policy type by adding single nominee with 100 share
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Gender>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and Click on Proceed button
	And User should enter <Borrower's Address: Address Line 1>, <Borrower's Address: Address Line 2>, <Borrower's Address: Address Line 3>, <Borrower's Address: State/UT>, <Borrower's Address: Pin Code> and click on proceed button in Borrower address page
	Then User should enter Nominee <NOMINEE #1:Nominee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <NOMINEE #1: Nominee's First Name>, <NOMINEE #1: Nominee's Sur Name>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)>, <NOMINEE #1: Nominee's Gender>, <NOMINEE #1: Nominee's Relationship with Borrower>, <NOMINEE #1: %share if multiple Nominees>, <NOMINEE #1: Nominee's  Mobile Number>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in Nominee page and click on Save and submit button
	When Nominee is less than eighteen years user should enter Appointee details <Appointee's Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Appointee's First Name>, <Appointee's SurName>, <Appointee's Gender>, <Appointee's Marital Status>, <Appointee's DOB (DD/MM/YYYY)>, <Appointee's ID NO.>, <Appointee's Relationship with the borrower>, <NOMINEE #1: Nominee's DOB (DD/MM/YYYY)> in Appointee page and click on Save and submit button
	When role associated with the loan is joint then user should enter details <Secondary Member details (Joint Life/Co borrower): Salutation (Dr, Miss, Mr, Mrs, Ms)>, <Secondary Member details (Joint Life/Co borrower): First Name>, <Secondary Member details (Joint Life/Co borrower): SurName>, <Secondary Member details (Joint Life/Co borrower): Mobile No.>, <Secondary Member details (Joint Life/Co borrower):  Email ID>, <Secondary Member details (Joint Life/Co borrower): Customer ID>, <Secondary Member details (Joint Life/Co borrower): Loan Id>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)> in secondary members details
	Then Verify the successful messages and click go to Dashboard button

@durgaTestCase18
@DataSource:PremiumCalculatorDataNominee100percentshare.xlsx @DataSet:SampleReport
Scenario: Verify FIG User able to navigate to Insurance Application page after premium calculation by clicking on Create Insurance Application button
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then Verify with premium Calculator Output title

@durgaTestCase21
@DataSource:PremiumCalculatorDataNominee100percentshare.xlsx @DataSet:SampleReport
Scenario: Verify FIG User able to enter mandatory values  for fields(Salutation,First Name, SurName, Loan ID, Customer ID, Gender (drop down), Mobile Number after clicking on Borrower details tab.
	Given Login into Suraksha Portal
	Then Verify navigated to Dashboard page
	Then Click Create application on the left side of the screen
	Then Click on Premium Calculator in Create application and Verify Title of the page
	Then User should enter <FinancialInstitution>, <Region (North,East,West,South,South1,South2)> and <Branch Name> information
	Then User should enter <Policy No.>, <Roles associated with the loan (Single Life, Joint-Life, Co-borrower)>, <MOD(Single Premium,Regular Premium)>, <Total Tenure (Months/Years)>, <Cover Amount (Sanctioned Loan Amount)> and <Is premium funded? (Yes/ No)> Policy Details
	Then User should enter <Borrower's Address: State/UT>,<Borrower's Gender>, <Date of Birth (DD/MM/YYYY)>, <Date Of Birth of Secondary Insured (Joint-Life/Co borrower) (DD/MM/YYYY)>, <Secondary Member details (Joint Life/Co borrower): Gender> and <Date of commencement of loan/cover> in the BorrowerDetails section
	Then User should click on Create Insurance Application button on Premium Output page
	Then User should select <IS DOGH/SMQ SUBMITTED> and  <Reference UTR NO.> and Click on preceed button
	Then User should enter <Borrower's First Name>, <Borrower's Sur Name>, <Borrower's Mobile No.>, <Borrower's Email Id>, <Loan ID>, <Temporary loan ID>, <Customer ID> and then verify
