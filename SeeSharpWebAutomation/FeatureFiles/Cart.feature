Feature: ShoppingCart

@Regression
@TopPriority

Scenario: FillTheCartAndProceed
	Given As the user picks 1st promoted item from the cart
	And Checkouts to the cart
	When User proceeds to check out
	Then User Logs in
	| Email            | Password   |
	| seesharp@test.ts | SeeSharp1! |
	And User enters shipping address
	| State     | City       | ZipCode | Street        |
	| Tennessee | Gatlinburg | 37738   | Ownby Cir 442 |
	And User picks a payment method
	And Finishes

Scenario: EmpyTheCart
	Given As the user picks 1st promoted item from the cart
	And Checkouts to the cart
	When User deletes the items in the card
	Then User signs out
	

	