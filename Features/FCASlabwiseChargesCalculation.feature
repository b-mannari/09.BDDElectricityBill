Feature: FCA Slabwise Charges Calculation
As a user I should be be able to calculate the FCA charges slabwise which means the Fuel Cost Adjustment.
       E = A (units) * 0.13 i.e. 13 paise per unit

Scenario Outline:Calculate the FCA Slabwise Charges for the Domestic Electricity Consumer in Slab 1 for consumption between 1 to 50 units
	Given I consumed <units> units in a given month
	When the state XOZ electricity bill gets generated
	Then the total fca charges as fca amounted to Rs<fcachargestotal>

	Examples:
		| units | fcachargestotal |
		| 1     | 0.13            |
		| 40    | 5.20            |
		| 50    | 6.50            |

Scenario Outline:Calculate the FCA Slabwise Charges for the Domestic Electricity Consumer in Slab 2 for consumption between 51 to 150 units
	Given I consumed <units> units in a given month
	When the state XOZ electricity bill gets generated
	Then I should be charged with an fca amount of Rs<fcaslab1total> for Slab1
	And I should be charged with an fca amount of Rs<fcaslab2total> for Slab2
	And the total fca charges as fca amounted to Rs<fcachargestotal>

	Examples:
		| units | fcaslab1total | fcaslab2total | fcachargestotal |
		| 51    | 6.50          | 0.13          | 6.63            |
		| 100   | 6.50          | 6.50          | 13.00           |
		| 150   | 6.50          | 13.00         | 19.50           |

Scenario Outline:Calculate the FCA Slabwise Charges for the Domestic Electricity Consumer in Slab 3 for consumption between 151 to 300 units
	Given I consumed <units> units in a given month
	When the state XOZ electricity bill gets generated
	Then I should be charged with an fca amount of Rs<fcaslab1total> for Slab1
	And I should be charged with an fca amount of Rs<fcaslab2total> for Slab2
	And I should be charged with an fca amount of Rs<fcaslab3total> for Slab3
	And the total fca charges as fca amounted to Rs<fcachargestotal>

	Examples:
		| units | fcaslab1total | fcaslab2total | fcaslab3total | fcachargestotal |
		| 151   | 6.50          | 13.00         | 0.13          | 19.63           |
		| 200   | 6.50          | 13.00         | 6.50          | 26.00           |
		| 300   | 6.50          | 13.00         | 19.50         | 39.00           |

Scenario Outline:Calculate the FCA Slabwise Charges for the Domestic Electricity Consumer in Slab 4 for consumption above 300 units
	Given I consumed <units> units in a given month
	When the state XOZ electricity bill gets generated
	Then I should be charged with an fca amount of Rs<fcaslab1total> for Slab1
	And I should be charged with an fca amount of Rs<fcaslab2total> for Slab2
	And I should be charged with an fca amount of Rs<fcaslab3total> for Slab3
	And I should be charged with an fca amount of Rs<fcaslab4total> for Slab4
	And the total fca charges as fca amounted to Rs<fcachargestotal>

	Examples:
		| units | fcaslab1total | fcaslab2total | fcaslab3total | fcaslab4total | fcachargestotal |
		| 301   | 6.50          | 13.00         | 19.50         | 0.13          | 39.13           |
		| 400   | 6.50          | 13.00         | 19.50         | 13.00         | 52.00           |
		| 1000  | 6.50          | 13.00         | 19.50         | 91.00         | 130.00          |