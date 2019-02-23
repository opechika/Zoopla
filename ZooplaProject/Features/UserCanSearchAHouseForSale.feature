Feature: UserCanSearchAHouseForSale
	In order to buy a house
	As a customer
	I want the ability to search for a house of my choice

Scenario Outline: Search for a Property
	Given I am on Zoopla homepage
	When I enter "<Search>" into search feild
	And I select "<MinPrice>" as minimum price
	And I select "<MaxPrice>" as maximum price
	And I select "<PropType>" from the property type
	And I select "<Bedrooms>" as number room
	And I click on search button
	Then the result of the "<Search>" is displayed

Scenarios: 
| Search  | MinPrice | MaxPrice | PropType | Bedrooms |
| WA14    | £200,000 | £300,000 | Houses   | 2        |
| Salford | £90,000  | £150,000 | Flats    | 3        |
