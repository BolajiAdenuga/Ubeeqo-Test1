Feature: Booking
	A user on ubeeqo website
	While trying to book a vehicle
	A modal pop-up should displayed blocking the booking process 

	Rule: A user shouldn't be able to book a vehicle without viewing the pop-up

@mytag
Scenario: Booking
Given I navigate to Ubeeqo website 
	When I enter the username "interviewtechnicaltest3@ubeeqo.com"
	And I enter the password "34ZkdK04VXk5"
	And I click on login button
	And I click on agree button on the cookies banner
	And I enter a location "London, Uk"
	And I click on book a vehicle 
	Then a validation modal pop up displayed blocking the bookings
