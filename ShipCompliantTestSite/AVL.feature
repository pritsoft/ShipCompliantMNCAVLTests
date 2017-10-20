Feature: AVL
	In order to valid compliance 
	As a supplier
	I want to import shipments so they can be validated
	
Scenario: Aggregate Volume Limits validated
	Given I am on the login screen
		And I enter an avl email address
		And I enter an avl password
		And I submit my credentials
		And I am on the the home screen
		And I go to the import new order file page
		And I upload an avl sales order file 
		And I choose a spreadsheet mapping
		And I choose the order source
		And I choose an import detail
		And I overwrite existing sales orders
		And I expand advance options
		And I set a ship date 
		And I set a fulfillment location
		And I set a fulfillment type
		And I set a sale type
		And I set a license relationship
		And I set a shipping service
	When I submit my settings
	Then I should see the pending order imports page
	And I should see the number of passed address checks is 12
	And I should see the number of passed product checks is 12
	And I should see the number of passed compliance checks is 9
	And I should see the number of failed compliance checks is 3
	And I should see an aggregate volume limit compliance failure 
	And I display the results grid
	And I should see the associated sales order key 
	And I should see the associated customer
	And I should see the associated failed status 
	And I cancel the import
	And I close the confirmation popup
	And I close the application
	And I close the browser