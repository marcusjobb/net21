Feature: Nedräknare till julafton
Background: Användaren är en jul-fantast och längtar till jul och vinter
Given: Dagens datum är före julafton samma år
When: Metoden för beräkning körs med dagens datum som inparameter
Then: Metoden ska returnera antalet dagar kvar till jul

@xmas
Scenario: Days till christmas eve
	Given That today is 2022-01-28
	When the method is called 
	Then it should return 330


