Feature: Creditcard

@mytag
Scenario: Succes creditcard validation
	Given I enter a 16 number creditcard number
	When I press validate
	Then I should see the succes message