Feature: Login 
	A valid login steps 
	As a user of ubeeqo
	I want to have access to the website 
	So that i can book a vehicle

	Rule: Every user should input their login details to have access to the website

@mytag
Scenario: Valid login steps 
	Given I navigate to Ubeeqo website 
	When I enter the username "interviewtechnicaltest3@ubeeqo.com"
	And I enter the password "34ZkdK04VXk5"
	And I click on login button
	And I click on agree button on the cookies banner
	Then ubeeqo logo banner is displayed