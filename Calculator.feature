Feature: Calculator  
In order to check the functionality
As a user
I should find Sum, Dev, Multi and Minus of numbers 

	
@mytag
Scenario: Minus two numbers
	Given I have written <55> and <5>
	When I have entered '-'
	Then the result should be <50> on the screen


Scenario: Multi two numbers
	Given I have written <5> and <5>
	When I have entered '*'
	Then the result should be <25> on the screen

	
Scenario:  Div two numbers
	Given I have written <5> and <5>
	When I have entered '/'
	Then the result should be <1> on the screen

Scenario: Plus two numbers
	Given I have written <5> and <5>
	When I have entered '+'
	Then the result should be <10> on the screen

