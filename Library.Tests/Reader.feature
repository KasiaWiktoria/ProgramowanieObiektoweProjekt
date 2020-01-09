Feature: Reader
	In order to check out libitem
	As a Reader
	I want to add libitem to CheckOutList

@mytag
Scenario: Check out book
	Given I choose libitem
	When I check out libitem
	Then the result should be libitem on my CheckOutList