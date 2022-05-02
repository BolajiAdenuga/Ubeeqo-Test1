Feature: AccountSettings
	As a user on ubeeqo website
	I want to be able open the account settings
	I want to be able to change my first and last name of the account
	So i can have a new name on the ubeeqo website

@mytag
Scenario: Change of First and Last name 
	Given I navigate to Ubeeqo website 
	When I enter the username "interviewtechnicaltest3@ubeeqo.com"
	And I enter the password "34ZkdK04VXk5"
	And I click on login button
	And I click on agree button on the cookies banner
	And I click on personal profile on the header
	And I clcik on account settings
	And I enter first name "Temi"
	And I enter last name "Dayo"
	And I click on save changes button
	Then A success image is displayed 