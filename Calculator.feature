Feature: Calculator  
In order to check the functionality
As a user
I should find Sum, Dev, Multi and Minus of numbers 

	
@mytag
Scenario: Plus two numbers
	Given I have entered 5 into the calculator
	And I entered 5 into the calculator 
	When I have entered +
	Then the Sum result should be 10 on the screen


Scenario: Minus two numbers
	Given I have entered 30 into the calculator
	And I entered 5 into the calculator
	When I have entered -
	Then the Minus result should be 25 on the screen


Scenario: Multi two numbers
	Given I have entered 5 into the calculator
	And I entered 5 into the calculator
	When I have entered *
	Then the Multi result should be 25 on the screen

	
Scenario:  Div two numbers
	Given I have entered 40 into the calculator
	And I entered 5 into the calculator
	When I have entered /
	Then the Div result should be 8 on the screen


