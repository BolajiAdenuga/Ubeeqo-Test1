Feature:  Logout
	A valid logout steps 
	As a user of ubeeqo
	After having access to the website
	And i can sign out of the website


@mytag
Scenario: Valid logout
	Given I navigate to Ubeeqo website 
	When I enter the username "interviewtechnicaltest3@ubeeqo.com"
	And I enter the password "34ZkdK04VXk5"
	And I click on login button
	And I click on agree button on the cookies banner
	And I click on personal profile on the header 
	And I click on sign out on the dropdown
	Then logout page is displayed 