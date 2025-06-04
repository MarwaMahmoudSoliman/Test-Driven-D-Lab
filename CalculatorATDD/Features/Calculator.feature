Feature: Calculator

Numbers addition

@add
Scenario: Add Numbers chosen by user
	Given User enters 50 into calculator
	And User enters 30 into calculator
	And  User enters 10 into calculator
	When User press add
	Then Sum should be 90
