Feature: CAVL
	In order to valid compliance 
	As a supplier
	I want to import shipments so they can be validated
	
 Scenario: MN Customer Aggregate Volume Limits validated
	Given I am on the login screen
		And I enter an email address
		And I enter a password
		And I submit my credentials
		And I am on the the home screen
		And I go to the import new order file page
		And I upload MN sales order file 
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
	And I should see the number of passed address checks is 10
	And I should see the number of passed product checks is 10
	And I should see the number of passed compliance checks is 7
	And I should see the number of failed compliance checks is 3
	And I should see a customer aggregate volume limit compliance failure 
	And I display the results grid
	And I set actions to compliance check only
	And I should see the associated sales order key 
	And I should see the associated customer
	And I should see the associated failed status 
	And I cancel the import
	And I close the confirmation popup
	And I close the application
	And I close the browser

	Scenario: Restrictive Customer Aggregate Volume Limits validated
	Given I am on the login screen
		And I enter an email address
		And I enter a password
		And I submit my credentials
		And I am on the the home screen
		And I go to the import new order file page
		And I upload Restrictive sales order file 
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
	And I should see the number of passed address checks is 48
	And I should see the number of passed product checks is 48
	And I should see the number of passed compliance checks is 31
	And I should see the number of failed compliance checks is 17
	And I should see a customer aggregate volume limit compliance failure 
	And I display the results grid
	And I set actions to compliance check only
	And I should see the associated sales order key 
	And I should see the associated customer
	And I should see the associated failed status 
	And I cancel the import
	And I close the confirmation popup
	And I close the application
	And I close the browser

	Scenario: Super Supplier Customer Aggregate Volume Limits validated
	Given I am on the login screen
		And I enter a Supersupplier email address
		And I enter a Supersupplier password
		And I submit my credentials
		And I am on the the Supersupplier home screen
		And I go to the import new order file page
		And I upload sales order file 
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
	And I should see the number of passed address checks is 84
	And I should see the number of passed product checks is 84
	And I should see the number of passed compliance checks is 66
	And I should see the number of failed compliance checks is 18
	And I should see a customer aggregate volume limit compliance failure 
	And I display the results grid
	And I set actions to compliance check only
	And I should see the associated sales order key 
	And I should see the associated customer
	And I should see the associated failed status 
	And I cancel the import
	And I close the confirmation popup
	And I close the application
	And I close the browser

	Scenario: Customer Aggregate Volume Limits validated
	Given I am on the login screen
		And I enter an email address
		And I enter a password
		And I submit my credentials
		And I am on the the home screen
		And I go to the import new order file page
		And I upload sales order file 
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
	And I should see the number of passed address checks is 84
	And I should see the number of passed product checks is 84
	And I should see the number of passed compliance checks is 66
	And I should see the number of failed compliance checks is 18
	And I should see a customer aggregate volume limit compliance failure 
	And I display the results grid
	And I set actions to compliance check only
	And I should see the associated sales order key 
	And I should see the associated customer
	And I should see the associated failed status 
	And I cancel the import
	And I close the confirmation popup
	And I close the application
	And I close the browser